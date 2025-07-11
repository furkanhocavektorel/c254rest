using obs.Context;
using obs.dto;
using obs.entity;
using obs.entity.enums;
using obs.service.abstracts;
using obs.util;

namespace obs.service.concretes
{
    public class BranchService : IBranchService
    {
        ObsContext context;
        JwtManager jwtManager;
        IAuthService authService;
        AuthUtil authUtil;


        public BranchService(ObsContext context, JwtManager jwtManager, IAuthService authService, AuthUtil authUtil)
        {
            this.context = context;
            this.jwtManager = jwtManager;
            this.authService = authService;
            this.authUtil = authUtil;

        }

        public void save(string token, BranchSaveRequestDto dto)
        {

            if (!(authUtil.isAdmin(token) || authUtil.isManager(token)))
            {
                throw new Exception("yetkiniz yok");
            }

            Branch branch = new Branch();
            branch.Name = dto.Name;
            branch.Description = dto.Desc;

            context.Branches.Add(branch);
            context.SaveChanges();



        }
    }
}
