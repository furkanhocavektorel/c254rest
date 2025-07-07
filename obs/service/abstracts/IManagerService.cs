using obs.dto;

namespace obs.service.abstracts
{
    public interface IManagerService
    {
        void save(AuthSaveRequestDto request, long authId);
    }
}
