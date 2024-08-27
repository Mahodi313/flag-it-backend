using flag_it_backend.Models;

namespace flag_it_backend.Repositories.Interfaces
{
    public interface ICountryRepository
    {
        public Task<CountryModel> GetByNameAsync(string name);
        public Task<List<CountryModel>> GetCountriesByContinentAsync(string continent);
    }
}
