using Domain.Entities;
using Domain.Interfaces.Models;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CityService : BaseService<Cities>, ICityService
    {
        private readonly ICityRepository _Repository;

        public CityService(ICityRepository Repository) : base(Repository) => _Repository = Repository;

        public ZipCodeModel? SearchByCep(string zipCode) => _Repository.SearchByCep(zipCode);
    }
}
