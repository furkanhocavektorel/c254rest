using obs.Context;
using obs.dto.builder;
using obs.dto.request;
using obs.dto.response;
using obs.entity;
using obs.entity.builder;
using obs.entity.enums;
using obs.service.abstracts;
using obs.util;

namespace obs.service.concretes
{
    public class AuthService : IAuthService
    {
        ObsContext context;
        IStudentService studentService;
        //ITeacherService teacherService;
        IManagerService managerService;
        JwtManager jwtManager;

        public AuthService(ObsContext context, IStudentService studentService, ITeacherService teacherService, IManagerService managerService, JwtManager jwtManager)
        {
            this.context = context;
            this.studentService = studentService;
            // this.teacherService = teacherService;
            this.managerService = managerService;
            this.jwtManager = jwtManager;
        }

        public AuthResponseDto save(AuthSaveRequestDto request)
        {
            Role? role = context.Roles.Find(request.RoleId);
            RoleResponseDto roleResponse = new RoleResponseDto();
            roleResponse.RoleId = role.Id; // 77
            roleResponse.RoleName = role.Name.ToString();

            Auth auth = new Auth();
            auth.IdentityNumber = request.IdentityNumber;
            auth.RoleId = request.RoleId;
            auth.Password = request.Password;

            auth = context.Auths.Add(auth).Entity;
            context.SaveChanges();

            // SOLID
            // Solide aykırı bir yaklaşım bu
            // solid için her bir role de ayrı endpoint olmalı


            if (role.Name.Equals(ERole.STUDENT))
            {
                studentService.save(request, auth.Id);
            }
            else if (role.Name.Equals(ERole.MANAGER))
            {
                managerService.save(request, auth.Id);
            }
            else if (role.Name.Equals(ERole.TEACHER))
            {
                //         teacherService.save(request, auth.Id);
                //Teacher teacher = new Teacher();
                //teacher.Surname = request.Surname;
                //teacher.Name = request.Name;
                //teacher.AuthId = auth.Id;

                Teacher teacher = Teacher.builder()
                    .authId(auth.Id)
                    .name(request.Name)
                    .build();



                context.Teachers.Add(teacher);
                context.SaveChanges();



                RoleResponseDto responseDto = new RoleResponseDtoBuilder()
                                                .getSetRoleName("asd")
                                                .build();


            }
            else
            {
                throw new Exception("role bulunamadi:!!!!!");
            }

            AuthResponseDto authResponseDto = new AuthResponseDto();
            authResponseDto.IdentityNumber = auth.IdentityNumber;
            authResponseDto.AuthId = auth.Id;
            authResponseDto.role = roleResponse;

            return authResponseDto;

        }


        public string login(string tckn, string password)
        {
            Auth? auth = context.Auths.FirstOrDefault(x => x.IdentityNumber.Equals(tckn));
            if (auth == null)
            {
                throw new Exception(message: "tckn ye ait birisi bulunamadi.");
            }

            if (!auth.Password.Equals(password))
            {
                throw new Exception(message: "yanlis sifre.");
            }

            string token = jwtManager.CreateToken(auth.Id);
            return token;

        }

        public Auth? getById(long id)
        {
            return context.Auths.Find(id);
        }
    }
}
