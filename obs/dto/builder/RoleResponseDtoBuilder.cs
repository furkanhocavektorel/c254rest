using obs.dto.response;

namespace obs.dto.builder
{
    public class RoleResponseDtoBuilder
    {
        private long RoleId=0;
        private string? RoleName=null;

        public RoleResponseDtoBuilder getSetRoleId(long roleId)
        {
            this.RoleId = roleId;
            return this;
        }

        public RoleResponseDtoBuilder getSetRoleName(string name)
        {
            this.RoleName = name;
            return this;
        }

        public RoleResponseDto build()
        {
            RoleResponseDto dto = new RoleResponseDto();
            dto.RoleName = this.RoleName;
            dto.RoleId = this.RoleId;
            return dto;
        }

    }
}
