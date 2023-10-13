using Data.DB;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Models;

namespace Data.Repositories
{
    public class CityRepository : BaseRepository<Cities>, ICityRepository
    {
        public CityRepository(CepBrasilDB ctx) : base(ctx) { }

        public ZipCodeModel? SearchByCep(string zipCode)
        {
            return (from c in _ctx.Cities
                    join s in _ctx.States on c.StateID equals s.StateID
                    where c.ZipCode == zipCode
                    select new ZipCodeModel
                    {
                        ZipCode = zipCode,
                        City = c.City,
                        Capital = c.Capital,
                        State = s.State,
                        FU = s.FU
                    }).FirstOrDefault();
        }

        public List<Cities> SearchByState(string fu)
        {
            return (from c in _ctx.Cities
                    join s in _ctx.States on c.StateID equals s.StateID
                    where s.FU == fu
                    select c).ToList();
        }

        public List<Cities> SearchByState(int stateId)
        {
            return _ctx.Cities.Where(x => x.StateID == stateId).ToList();
        }
    }
}
