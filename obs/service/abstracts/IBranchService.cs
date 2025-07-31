using obs.dto.request;
using obs.entity;

namespace obs.service.abstracts
{
    public interface IBranchService
    {
        void save(string token,BranchSaveRequestDto dto);
        Branch? getBranch(long id);
    }
}
