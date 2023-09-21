using Domain.Entities;
using Domain.Interfaces.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IAddressRepository : IBaseRepository<Adresses>
    {
        ZipCodeModel? SearchByCep(string zipCode);
        List<ZipCodeModel> SearchByAddress(string address);
    }
}
