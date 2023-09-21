using Domain.Entities;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface IStateService : IBaseService<States>
    {
        ReturnModel<States> SearchByState();
    }
}
