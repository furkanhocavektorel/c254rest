using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace obs.entity
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime? CreateAt { get; set; } = default(DateTime?);
        public DateTime? UpdatedAt { get; set; } = default(DateTime?);
        public string? CreateBy { get; set; }
        public string? UpdateBy { get; set; }
        public bool? Deleted { get; set; } = false;
    }
}
