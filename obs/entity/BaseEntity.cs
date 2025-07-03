namespace obs.entity
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreateBy { get; set; }
        public string? UpdateBy { get; set; }
        public bool? Deleted { get; set; }
    }
}
