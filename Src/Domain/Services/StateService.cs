using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class StateService : BaseService<States>, IStateService
    {
        private readonly IStateRepository _Repository;

        public StateService(IStateRepository Repository) : base(Repository) => _Repository = Repository;

        public List<States> SearchByState()
        {
            var result = _Repository.SearchByState();

            if (result == null)
                throw new ArgumentException("Não há regitro de estado cadastrado.");

            return result;
        }
    }
}
