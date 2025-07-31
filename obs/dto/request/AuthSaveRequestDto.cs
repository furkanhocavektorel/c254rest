namespace obs.dto.request
{
    public class AuthSaveRequestDto
    {
        public string IdentityNumber { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public string? ClassLevel { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
