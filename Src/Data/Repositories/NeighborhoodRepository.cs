using Data.DB;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class NeighborhoodRepository : BaseRepository<Neighborhoods>, INeighborhoodRepository
    {
        public NeighborhoodRepository(CepBrasilDB ctx) : base(ctx)
        {
            
        }

        public List<Neighborhoods> SearchByStateAndCity(int stateID, int cityID)
        {
            return _ctx.Neighborhoods.Where(x => x.StateID == stateID && x.CityID == cityID).ToList();
        }

        public List<Neighborhoods> SearchByStateAndCity(string fu, string city)
        {
            return (from n in _ctx.Neighborhoods
                    join c in _ctx.Cities on n.CityID equals c.CityID
                    join s in _ctx.States on n.StateID equals s.StateID
                    where s.FU == fu && c.City == city
                    select n).ToList();
        }
    }
}
