using Domain.Entities;
using Domain.Models;

namespace Domain.Interfaces.Repositories
{
    public interface ICityRepository : IBaseRepository<Cities>
    {
        ZipCodeModel? SearchByCep(string zipCode);
        List<Cities> SearchByState(int stateId);
        List<Cities> SearchByState(string fu);
        
    }
}
