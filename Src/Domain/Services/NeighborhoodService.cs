using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class NeighborhoodService : BaseService<Neighborhoods>, INeighborhoodService
    {
        private readonly INeighborhoodRepository _Repository;
        public NeighborhoodService(INeighborhoodRepository Repository) : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
