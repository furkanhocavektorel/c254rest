using obs.dto;

namespace obs.service.abstracts
{
    public interface IAuthService
    {
        AuthResponseDto save(AuthSaveRequestDto request);
    }
}
