using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using obs.config;
using obs.dto;
using obs.service.abstracts;

namespace obs.Controllers
{
    [Route(EndPoints.Auth)] // api/v1/auth
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService authService;
        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost(EndPoints.Register)]
        public AuthResponseDto save([FromBody] AuthSaveRequestDto request)
        {
            return authService.save(request);

        }

        [HttpGet("login/{tckn}")]
        public string login([FromRoute] string tckn,[FromQuery] string password)
        {

            return authService.login(tckn, password);
        }


        //[HttpPost("login2/{tckn}/{ram?}/{ekrankarti?}")]
        //public string login2([FromRoute] string tckn)
        //{

        //    return authService.login(tckn, password);
        //}


    }
}
