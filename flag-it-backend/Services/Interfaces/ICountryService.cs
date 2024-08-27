using flag_it_backend.Models;

namespace flag_it_backend.Services.Interfaces
{
    public interface ICountryService
    {
        public Task<List<CountryModel>> GetAll();
        public Task<List<CountryModel>> GetCountriesByContinent(string continent);
        public Task<CountryModel> GetById(int id);
        public Task<CountryModel> GetByName(string name);
    }
}
