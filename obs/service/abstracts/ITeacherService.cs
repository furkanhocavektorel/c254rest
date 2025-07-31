using obs.dto.request;

namespace obs.service.abstracts
{
    public interface ITeacherService
    {
        void assignBranch(AssignBranchRequestDto dto);
        void save(AuthSaveRequestDto request, long authId);
    }
}
