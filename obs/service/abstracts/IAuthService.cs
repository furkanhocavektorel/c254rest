using obs.dto;

namespace obs.service.abstracts
{
    public interface IAuthService
    {
        string login(string tckn, string password);
        AuthResponseDto save(AuthSaveRequestDto request);
        string TokenOnayı(string token);
    }
}
