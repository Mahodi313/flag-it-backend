using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories;
using flag_it_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flag_it_backend.UnitTests.RepositoryTests
{
    public class CountryRepositoryTesting : IDisposable
    {
        private ICountryRepository _countryRepository;
        private AppDbContext _dbContext;
        private ServiceProvider _serviceProvider;

        public CountryRepositoryTesting()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TestDb"));

            services.AddScoped<ICountryRepository, CountryRepository>();

            _serviceProvider = services.BuildServiceProvider();

            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            _countryRepository = _serviceProvider.GetRequiredService<ICountryRepository>();

            SeedDatabase();
        }

        [Fact]
        public async Task GetByName_ReturnsCorrectCountry()
        {
            var country = await _countryRepository.GetByNameAsync("CountryA");

            Assert.NotNull(country);
            Assert.Equal("CountryA", country.Name);
        }

        [Fact]
        public async Task GetByNameAsync_ThrowsException_WhenCountryNotFound()
        {
            await Assert.ThrowsAsync<KeyNotFoundException>(() => _countryRepository.GetByNameAsync("FakeCountry"));
        }

        [Fact]
        public async Task GetCountriesByContinentAsync_ReturnsCorrectCountries()
        {
            var countries = await _countryRepository.GetCountriesByContinentAsync("Europe");

            Assert.NotNull(countries);

            Assert.Equal(2, countries.Count()); // Europe has 2 countries in the seeded data

            Assert.Contains(countries, c => c.Name == "CountryA");
            Assert.Contains(countries, c => c.Name == "CountryC");
        }

        [Fact]
        public async Task GetCountriesByContinentAsync_ReturnsEmptyList_WhenNoCountriesFound()
        {

            var countries = await _countryRepository.GetCountriesByContinentAsync("FakeContinent");

            Assert.NotNull(countries);
            Assert.Empty(countries); // Should return an empty list
        }

        private void SeedDatabase()
        {
            var countries = new List<CountryModel>
            {
                new CountryModel { Id = 1, Name = "CountryA", Continent = "Europe" },
                new CountryModel { Id = 2, Name = "CountryB", Continent = "Asia" },
                new CountryModel { Id = 3, Name = "CountryC", Continent = "Europe" },
                new CountryModel { Id = 4, Name = "CountryD", Continent = "Africa" }
            };

            _dbContext.Countries.AddRange(countries);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Dispose();
            _serviceProvider.Dispose();
        }
    }
}
