using Domain.Entities;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface ICityService : IBaseService<Cities>
    {
        ZipCodeModel? SearchByCep(string zipCode);
        List<Cities> SearchByState(int stateId);
        List<Cities> SearchByState(string fu);
    }
}
