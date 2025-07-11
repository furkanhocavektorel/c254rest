using obs.Context;
using obs.entity;
using obs.entity.enums;
using obs.service.abstracts;

namespace obs.util
{
    public class AuthUtil
    {
        JwtManager jwtManager;
        IAuthService authService;
        ObsContext context;

        public AuthUtil(JwtManager jwtManager, IAuthService authService, ObsContext context)
        {
            this.jwtManager = jwtManager;
            this.authService = authService;
            this.context = context;
        }

        public bool isAdmin(string token)
        {
            long id = long.Parse(jwtManager.ValidateToken(token));
            Auth? auth = authService.getById(id);

            if (auth == null)
            {
                throw new Exception("kullanici bulunamadi...");
            }

            Role role = context.Roles.Find(auth.RoleId);
            if (role == null)
            {
                throw new Exception("role bulunamadi");
            }

            return role.Name.Equals(ERole.ADMIN);
        }

        public bool isManager(string token)
        {
            long id = long.Parse(jwtManager.ValidateToken(token));
            Auth? auth = authService.getById(id);

            if (auth == null)
            {
                throw new Exception("kullanici bulunamadi...");
            }

            Role role = context.Roles.Find(auth.RoleId);
            if (role == null)
            {
                throw new Exception("role bulunamadi");
            }

            return role.Name.Equals(ERole.MANAGER);
        }

    }
}
