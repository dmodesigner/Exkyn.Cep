using Domain.Entities;
using Domain.Interfaces.Models;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Domain.Services
{
    public class CityService : BaseService<Cities>, ICityService
    {
        private readonly ICityRepository _Repository;

        public CityService(ICityRepository Repository) : base(Repository) => _Repository = Repository;

        public ReturnModel<ZipCodeModel> SearchByCep(string zipCode)
        {
            var zipCodeModel = _Repository.SearchByCep(zipCode);

            if (zipCodeModel == null)
            {
                return new ReturnModel<ZipCodeModel>
                {
                    Success = false,
                    Message = $"Não encontramos nenhum endereço com a informação {zipCode}."
                };
            }

            return new ReturnModel<ZipCodeModel>
            {
                Success = true,
                Message = "Ok",
                Object = zipCodeModel
            };
        }
    }
}
