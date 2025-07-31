using obs.Context;
using obs.dto.request;
using obs.entity;
using obs.service.abstracts;

namespace obs.service.concretes
{
    public class ManagerService : IManagerService
    {

        ObsContext context;
        public ManagerService(ObsContext context)
        {
            this.context = context;
        }
        public void save(AuthSaveRequestDto request, long authId)
        {
            Manager manager = new Manager();
            manager.Surname = request.Surname;
            manager.Name = request.Name;
            manager.AuthId = authId;

            context.Managers.Add(manager);
            context.SaveChanges();
        }
    }
}
