using Domain.Entities;
using Domain.Interfaces.Models;

namespace Domain.Interfaces.Services
{
    public interface ICityService : IBaseService<Cities>
    {
        ZipCodeModel? SearchByCep(string zipCode);
    }
}
