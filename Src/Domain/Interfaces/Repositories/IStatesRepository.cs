using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IStatesRepository : IBaseRepository<States>
    {
        List<States> SearchByState();
    }
}
