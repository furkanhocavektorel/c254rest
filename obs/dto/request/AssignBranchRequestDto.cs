namespace obs.dto.request
{
    public class AssignBranchRequestDto
    {
        public long TeacherId { get; set; }
        public List<long> BranchIds { get; set; }
    }
}
