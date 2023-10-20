using Domain.Entities;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface IAddressService : IBaseService<Adresses>
    {
        ZipCodeModel SearchByCep(string zipCode);
        List<ZipCodeModel> SearchByAddress(string address);
    }
}
