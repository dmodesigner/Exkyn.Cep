using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Domain.Services
{
    public class AddressService : BaseService<Adresses>, IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly ICityRepository _cityRepository;

        public AddressService(IAddressRepository addressRepository, ICityRepository cityRepository) : base(addressRepository)
        {
            _addressRepository = addressRepository;
            _cityRepository = cityRepository;
        }

        public ZipCodeModel SearchByCep(string zipCode)
        {
            if (string.IsNullOrEmpty(zipCode) || zipCode.Length != 8)
                throw new ArgumentException("Você deve informar o CEP no formato 99999999 ou 99999-999");

            zipCode = zipCode.Replace("-", "");

            if (!int.TryParse(zipCode, out int numero))
                throw new ArgumentException("O CEP não deve conter letras ou outros caracteres especiais.");

            var result = _addressRepository.SearchByCep(zipCode);

            if (result == null)
                result = _cityRepository.SearchByCep(zipCode);

            if (result == null)
                throw new ArgumentException($"Não foi possível encontrar nenhum endereço com o CEP {zipCode}");

            return result;
        }

        public List<ZipCodeModel> SearchByAddress(string address)
        {
            if (string.IsNullOrEmpty(address) || address.Length < 3)
                throw new ArgumentException("Você deve informar pelo menos 3 caracteres para realizar a busca de endereços.");

            address = address.Trim();

            var result = _addressRepository.SearchByAddress(address);

            if (result == null || result.Count() == 0)
                throw new ArgumentException($"Não localizamos nenhum endereço com o valor {address} informado.");

            return result;
        }
    }
}
