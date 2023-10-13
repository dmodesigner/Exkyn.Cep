using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface INeighborhoodRepository : IBaseRepository<Neighborhoods>
    {
        List<Neighborhoods> SearchByStateAndCity(int stateID, int cityID);
        List<Neighborhoods> SearchByStateAndCity(string fu, string city);
    }
}
