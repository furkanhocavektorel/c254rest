using obs.Context;
using obs.dto;
using obs.entity;
using obs.service.abstracts;

namespace obs.service.concretes
{
    public class StudentService : IStudentService
    {
        ObsContext context;
        public StudentService(ObsContext context)
        {
            this.context = context;
        }

        public void save(AuthSaveRequestDto request, long authId)
        {
            Student student = new Student();
            student.Surname = request.Surname;
            student.Name = request.Name;
            student.ClassLevel = request.ClassLevel;
            student.AuthId = authId;
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}
