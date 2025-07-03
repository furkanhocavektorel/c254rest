namespace obs.entity
{
    /*tckn (string)
sifre (string)
role */
    public class Auth : BaseEntity
    {
        public string IdentityNumber { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }

    }
}
