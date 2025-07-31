using obs.entity.builder;

namespace obs.entity
{
    public class Teacher: BaseEntity
    {
        public long AuthId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly? BirthDate { get; set; }
        public DateOnly? StartDate { get; set; }
        public string? Gender { get; set; }
        public string? Biography { get; set; }
        // SINIF ID tutulmalı
        public string? Sınıf { get; set; }

        // TODO: OGRETMENE BRANS VERILMELI (ENTITY OLARAK TUTULACAK)

        public decimal? Salary { get; set; }

        public static TeacherBuilder builder()
        {
            return new TeacherBuilder();
        }

    }
}
