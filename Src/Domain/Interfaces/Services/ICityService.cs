using Domain.Entities;
using Domain.Interfaces.Models;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface ICityService : IBaseService<Cities>
    {
        ReturnModel<ZipCodeModel> SearchByCep(string zipCode);
    }
}
