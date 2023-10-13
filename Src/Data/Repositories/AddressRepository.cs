using Data.DB;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Models;

namespace Data.Repositories
{
    public class AddressRepository : BaseRepository<Adresses>, IAddressRepository
    {
        public AddressRepository(CepBrasilDB ctx) : base(ctx) { }

        public ZipCodeModel? SearchByCep(string zipCode)
        {
            return (from e in _ctx.Adresses
                    join b in _ctx.Neighborhoods on e.NeighborhoodID equals b.NeighborhoodID
                    join c in _ctx.Cities on e.CityID equals c.CityID
                    join s in _ctx.States on e.StateID equals s.StateID
                    where e.ZipCode == zipCode
                    select new ZipCodeModel
                    {
                        ZipCode = zipCode,
                        Address = e.Address,
                        Neighborhood = b.Neighborhood,
                        City = c.City,
                        Capital = c.Capital,
                        State = s.State,
                        FU = s.FU
                    }).FirstOrDefault();
        }

        public List<ZipCodeModel> SearchByAddress(string address)
        {
            return (from e in _ctx.Adresses
                    join b in _ctx.Neighborhoods on e.NeighborhoodID equals b.NeighborhoodID
                    join c in _ctx.Cities on e.CityID equals c.CityID
                    join s in _ctx.States on e.StateID equals s.StateID
                    where e.Address.Contains(address)
                    select new ZipCodeModel
                    {
                        ZipCode = e.ZipCode,
                        Address = e.Address,
                        Neighborhood = b.Neighborhood,
                        City = c.City,
                        Capital = c.Capital,
                        State = s.State,
                        FU = s.FU
                    }).Take(100)
                    .ToList();
        }
    }
}
