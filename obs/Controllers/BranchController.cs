using Microsoft.AspNetCore.Mvc;
using obs.config;
using obs.dto;
using obs.service.abstracts;

namespace obs.Controllers
{
    [ApiController]
    [Route(EndPoints.BranchBase)]
    public class BranchController: ControllerBase
    {
        IBranchService branchService;

        public BranchController(IBranchService branchService)
        {
            this.branchService = branchService;
        }

        [HttpPost(EndPoints.Save+"{token}")]
        public void save([FromRoute] string token, [FromBody]BranchSaveRequestDto dto)
        {
            branchService.save(token,dto);

        }


    }
}
