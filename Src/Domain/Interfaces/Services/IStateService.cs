using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IStateService : IBaseService<States>
    {
        List<States> SearchByState();
    }
}
