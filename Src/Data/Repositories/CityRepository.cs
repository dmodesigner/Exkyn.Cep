using Data.DB;
using Domain.Entities;
using Domain.Interfaces.Models;
using Domain.Interfaces.Repositories;

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
    }
}
