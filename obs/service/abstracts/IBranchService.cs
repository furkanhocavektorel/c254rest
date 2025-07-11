using obs.dto;

namespace obs.service.abstracts
{
    public interface IBranchService
    {
        void save(string token,BranchSaveRequestDto dto);
    }
}
