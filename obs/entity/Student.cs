namespace obs.entity
{
    public class Student : BaseEntity
    {
        public long AuthId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly? BirthDate { get; set; }
        public DateOnly? StartDate { get; set; }
        public string? Gender { get; set; }
        public string? ClassLevel { get; set; }
        // SINIF ID tutulmalı
        public string? Sınıf { get; set; }
    }
}
