using Domain.Entities;
using Domain.Interfaces.Models;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Domain.Services
{
    public class AddressService : BaseService<Adresses>, IAddressService
    {
        private readonly IAddressRepository _Repository;
        private readonly ICityRepository _CityRepository;

        public AddressService(IAddressRepository Repository, ICityRepository CityRepository) : base(Repository)
        {
            _Repository = Repository;
            _CityRepository = CityRepository;
        }

        public ReturnModel<ZipCodeModel> SearchByCep(string zipCode)
        {
            zipCode = zipCode.Replace("-", "");

            #region Validações

            if (string.IsNullOrEmpty(zipCode) || zipCode.Length != 8)
                return new ReturnModel<ZipCodeModel>()
                {
                    Success = false,
                    Message = "Informe um cep valido (Formato: 99999999 ou 99999-999)"
                };

            if (!int.TryParse(zipCode, out int numero))
                return new ReturnModel<ZipCodeModel>()
                {
                    Success = false,
                    Message = "CEP deve conter apenas números"
                };

            #endregion

            var result = _Repository.SearchByCep(zipCode);

            if (result == null)
            {
                result = _CityRepository.SearchByCep(zipCode);

                if (result == null)
                {
                    return new ReturnModel<ZipCodeModel>()
                    {
                        Success = false,
                        Message = $"Não encontramos um endereço com o CEP: {zipCode}"
                    };
                }
            }

            return new ReturnModel<ZipCodeModel>()
            {
                Success = true,
                Message = "Ok",
                Object = result
            };
        }

        public ReturnModel<ZipCodeModel> SearchByAddress(string address)
        {
            address = address.Trim();

            #region Validações

            if (string.IsNullOrEmpty(address))
                return new ReturnModel<ZipCodeModel>()
                {
                    Success = false,
                    Message = "Informe um cep valido (Formato: 99999999 ou 99999-999)"
                };

            #endregion

            var result = _Repository.SearchByAddress(address);

            if (result == null || result.Count() == 0)
                return new ReturnModel<ZipCodeModel>()
                {
                    Success = false,
                    Message = $"Não encontramos nenhum endereço com a informação {address}."
                };

            return new ReturnModel<ZipCodeModel>()
            {
                Success = true,
                Message = "Ok",
                List = result
            };
        }
    }
}
