namespace obs.entity
{
    public class Manager : BaseEntity
    {
        public long AuthId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly? BirthDate { get; set; }
        public DateOnly? StartDate { get; set; }
        public string? Gender { get; set; }
        public string? Biography { get; set; }
    }
}
