namespace obs.dto.response
{
    public class AuthResponseDto
    {
        public string IdentityNumber { get; set; }
        public long AuthId { get; set; }

        public RoleResponseDto role { get; set; }

    }


}
