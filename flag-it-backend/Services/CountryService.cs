using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services.Interfaces;

namespace flag_it_backend.Services
{
    public class CountryService : ICountryService
    {

        public IGenericRepository<CountryModel> _countryRepo { get; set; }
        public ICountryRepository _countryRepo2 { get; set; }

        public CountryService(IGenericRepository<CountryModel> countryRepo, ICountryRepository countryRepo2)
        {
            _countryRepo = countryRepo;
            _countryRepo2 = countryRepo2;
        }

        public async Task<List<CountryModel>> GetAll()
        {
            return await _countryRepo.GetAllAsync();
        }

        public async Task<CountryModel> GetById(int id)
        {
            return await _countryRepo.GetByIdAsync(id);
        }

        public async Task<CountryModel> GetByName(string name)
        {
            return await _countryRepo2.GetByNameAsync(name);
        }

        public async Task<List<CountryModel>> GetCountriesByContinent(string continent)
        {
            return await _countryRepo2.GetCountriesByContinentAsync(continent);
        }
    }
}
