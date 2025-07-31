using obs.Context;
using obs.dto.request;
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

        public BranchService(ObsContext context, JwtManager jwtManager)
        {
            this.context = context;
            this.jwtManager = jwtManager;
        }

        public void save(string token, BranchSaveRequestDto dto)
        {
          
            Branch branch = new Branch();
            branch.Name = dto.Name;
            branch.Description = dto.Desc;
            context.Branches.Add(branch);
            context.SaveChanges();

        }


        public Branch? getBranch(long id)
        {
            return context.Branches.Find(id);
            
        }

    }
}
