using Domain.Entities;
using Domain.Interfaces.Models;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface IAddressService : IBaseService<Adresses>
    {
        ReturnModel<ZipCodeModel> SearchByCep(string zipCode);
        ReturnModel<ZipCodeModel> SearchByAddress(string address);
    }
}
