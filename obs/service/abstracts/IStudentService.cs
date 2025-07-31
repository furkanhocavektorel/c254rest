using obs.dto.request;

namespace obs.service.abstracts
{
    public interface IStudentService
    {
        void save(AuthSaveRequestDto request, long authId);
    }
}
