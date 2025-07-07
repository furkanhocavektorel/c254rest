using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using obs.dto;
using obs.service.abstracts;

namespace obs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService authService;
        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        public AuthResponseDto save(AuthSaveRequestDto request)
        {
            return authService.save(request);

        }



    }
}
