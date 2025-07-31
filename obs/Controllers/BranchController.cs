using Microsoft.AspNetCore.Mvc;
using obs.config;
using obs.dto.request;
using obs.service.abstracts;
using obs.util;

namespace obs.Controllers
{
    [ApiController]
    [Route(EndPoints.BranchBase)]
    public class BranchController: ControllerBase
    {
        IBranchService branchService;
        AuthUtil authUtil;

        public BranchController(IBranchService branchService, AuthUtil authUtil)
        {
            this.branchService = branchService;
            this.authUtil = authUtil;
        }

        [HttpPost(EndPoints.Save+"{token}")]
        public void save([FromRoute] string token, [FromBody]BranchSaveRequestDto dto)
        {
            if (!(authUtil.isAdmin(token) || authUtil.isManager(token)))
            {
                throw new Exception("Yetkiniz yok.");
            }
            branchService.save(token,dto);

        }


    }
}
