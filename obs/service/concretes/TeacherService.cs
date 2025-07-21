using Microsoft.EntityFrameworkCore;
using obs.Context;
using obs.dto;
using obs.entity;
using obs.service.abstracts;

namespace obs.service.concretes
{
    public class TeacherService : ITeacherService
    {
        ObsContext context;
        IBranchService branchService;
        public TeacherService(ObsContext context, IBranchService branchService)
        {
            this.context = context;
            this.branchService = branchService;
        }

        public void save(AuthSaveRequestDto request, long authId)
        {
            Teacher teacher = new Teacher();
            teacher.Surname = request.Surname;
            teacher.Name = request.Name;
            teacher.AuthId = authId;

            context.Teachers.Add(teacher);
            context.SaveChanges();
        }

        public void assignBranch(AssignBranchRequestDto dto)
        {

            Teacher? teacher = context.Teachers.Find(dto.TeacherId);

            if (teacher == null)
            {
                throw new Exception("ögretmen bulunamadı");

            }   
            context.Teacher_Branches
                    .Where(tb => tb.TeacherId == teacher.Id).ExecuteDelete();

            foreach(long branchId in dto.BranchIds)
            {
                Branch? branch = branchService.getBranch(branchId);
                if(branch == null)
                {
                    throw new Exception("brans bilgisi bulunamadı");
                }
                Teacher_Branch teacher_Branch = new Teacher_Branch();
                teacher_Branch.TeacherId = teacher.Id;
                teacher_Branch.BranchId = branch.Id;
                context.Teacher_Branches.Add(teacher_Branch);
                context.SaveChanges();
            }
        }

        private void deleteBranchForTeacher(Teacher,list)
        {

        }




    }
}

