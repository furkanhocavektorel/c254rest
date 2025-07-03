using obs.entity.enums;

namespace obs.entity
{
    public class Role : BaseEntity
    {
        
        public ERole Name { get; set; } 
        public string Description { get; set; }
    }
}
