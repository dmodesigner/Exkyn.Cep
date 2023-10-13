using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Domain.Services
{
    public class CityService : BaseService<Cities>, ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository) : base(cityRepository) => _cityRepository = cityRepository;

        public ZipCodeModel? SearchByCep(string zipCode) => _cityRepository.SearchByCep(zipCode);

        public List<Cities> SearchByState(int stateId) => _cityRepository.SearchByState(stateId);

        public List<Cities> SearchByState(string fu) => _cityRepository.SearchByState(fu);
    }
}
