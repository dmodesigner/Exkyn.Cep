using Domain.Entities;
using Domain.Interfaces.Models;

namespace Domain.Interfaces.Repositories
{
    public interface ICityRepository : IBaseRepository<Cities>
    {
        ZipCodeModel? SearchByCep(string zipCode);
    }
}
