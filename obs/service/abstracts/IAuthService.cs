using obs.dto;
using obs.entity;

namespace obs.service.abstracts
{
    public interface IAuthService
    {
        string login(string tckn, string password);
        AuthResponseDto save(AuthSaveRequestDto request);

        Auth? getById(long id);
    }
}
