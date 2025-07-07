using obs.dto;

namespace obs.service.abstracts
{
    public interface ITeacherService
    {
        void save(AuthSaveRequestDto request, long authId);
    }
}
