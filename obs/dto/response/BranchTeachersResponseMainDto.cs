namespace obs.dto.response
{
    public class BranchTeachersResponseMainDto
    {
        public long TeacherId { get; set; }
        public long TeacherName { get; set; }
        public List<BranchTeacherResponseDto> Branhces { get; set; }
    }
}
