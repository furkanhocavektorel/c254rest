using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using obs.dto;
using obs.service.abstracts;

namespace obs.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService authService;
        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("register")]
        public AuthResponseDto save(AuthSaveRequestDto request)
        {
            return authService.save(request);

        }

        [HttpPost("login")]
        public string login(string tckn, string password) { 
        
            return authService.login(tckn, password);
        }

        // TODO profilim sayfası için diğer kontrollerları kullan

        [HttpPost("token-patlat")]
        public string login(string token)
        {

            return authService.TokenOnayı(token);
        }


    }
}
