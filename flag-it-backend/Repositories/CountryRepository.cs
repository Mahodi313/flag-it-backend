using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace flag_it_backend.Repositories
{
    public class CountryRepository : ICountryRepository
    {

        public AppDbContext _context { get; set; }

        public CountryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CountryModel> GetByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Country name cannot be null or empty", nameof(name));
            }

            var country = await _context.Countries
                .FirstOrDefaultAsync(c => c.Name == name);

            if (country == null)
            {
                throw new KeyNotFoundException($"Country with name '{name}' was not found.");
            }

            return country;
        }

        public async Task<List<CountryModel>> GetCountriesByContinentAsync(string continent)
        {
            List<CountryModel> countries = await _context.Countries.Where(c => c.Continent == continent).ToListAsync();
            
            return countries;
        }
    }
}
