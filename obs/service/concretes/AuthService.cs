using obs.Context;
using obs.dto;
using obs.entity;
using obs.entity.enums;
using obs.service.abstracts;

namespace obs.service.concretes
{
    public class AuthService : IAuthService
    {
        ObsContext obsContext;
        IStudentService studentService;
        ITeacherService teacherService;
        IManagerService managerService;

        public AuthService(ObsContext obsContext)
        {
            this.obsContext = obsContext;
        }


        public AuthResponseDto save(AuthSaveRequestDto request)
        {
            Role? role = obsContext.Roles.Find(request.RoleId);
            RoleResponseDto roleResponse = new RoleResponseDto();
            roleResponse.RoleId = role.Id; // 77
            roleResponse.RoleName = role.Name.ToString();

            Auth auth = new Auth();
            auth.IdentityNumber= request.IdentityNumber;
            auth.RoleId= request.RoleId;
            auth.Password= request.Password;

            auth = obsContext.Auths.Add(auth).Entity;
            obsContext.SaveChanges();

            // SOLID
            // Solide aykırı bir yaklaşım bu
            // solid için her bir role de ayrı endpoint olmalı


            if (role.Name.Equals(ERole.STUDENT))
            {
                auth.Id;
            }
            else if (role.Name.Equals(ERole.MANAGER))
            {

            }
            else if (role.Name.Equals(ERole.TEACHER))
            {

            }
            else if (role.Name.Equals(ERole.EMPLOYEE))
            {

            }
            else
            {
                throw new Exception("role bulunamadi:!!!!!");
            }

            AuthResponseDto authResponseDto = new AuthResponseDto();
            authResponseDto.IdentityNumber = auth.IdentityNumber;

        
            authResponseDto.role = roleResponse;

            return authResponseDto;
         
        }
    }
}
