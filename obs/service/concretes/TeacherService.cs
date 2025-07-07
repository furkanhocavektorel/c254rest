using obs.Context;
using obs.dto;
using obs.entity;
using obs.service.abstracts;

namespace obs.service.concretes
{
    public class TeacherService : ITeacherService
    {
        ObsContext context;
        public TeacherService(ObsContext context)
        {
            this.context = context;
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
    }
}
