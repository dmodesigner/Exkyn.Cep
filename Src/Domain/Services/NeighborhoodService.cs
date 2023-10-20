using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class NeighborhoodService : BaseService<Neighborhoods>, INeighborhoodService
    {
        private readonly INeighborhoodRepository _neighborhoodRepository;

        public NeighborhoodService(INeighborhoodRepository neighborhoodRepository) : base(neighborhoodRepository) => _neighborhoodRepository = neighborhoodRepository;

        public List<Neighborhoods> SearchByStateAndCity(int stateID, int cityID) => _neighborhoodRepository.SearchByStateAndCity(stateID, cityID);

        public List<Neighborhoods> SearchByStateAndCity(string fu, string city) => _neighborhoodRepository.SearchByStateAndCity(fu, city);
    }
}
