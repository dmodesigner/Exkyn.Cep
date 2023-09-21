using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Domain.Services
{
    public class StatesService : BaseService<States>, IStateService
    {
        private readonly IStatesRepository _Repository;

        public StatesService(IStatesRepository Repository) : base(Repository) => _Repository = Repository;

        public ReturnModel<States> SearchByState()
        {
            var result = _Repository.SearchByState();

            if (result == null)
                return new ReturnModel<States>()
                {
                    Success = false,
                    Message = "Não encontramos nenhum estado para listar."
                };

            return new ReturnModel<States>()
            {
                Success = true,
                Message = "Ok",
                List = result
                    .OrderBy(x => x.State)
                    .ToList()
            };
        }
    }
}
