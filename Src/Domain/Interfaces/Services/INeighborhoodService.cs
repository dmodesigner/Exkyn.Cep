using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface INeighborhoodService : IBaseService<Neighborhoods>
    {
        List<Neighborhoods> SearchByStateAndCity(int stateID, int cityID);
        List<Neighborhoods> SearchByStateAndCity(string fu, string city);
    }
}
