using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services;
using flag_it_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace flag_it_backend.UnitTests.ServiceTests
{
    public class CountryServiceFixture : IDisposable
    {
        public ICountryService CountryService { get; private set; }
        public ServiceProvider ServiceProvider { get; private set; }
        public AppDbContext DbContext { get; private set; }

        public CountryServiceFixture()
        {
            var services = new ServiceCollection();

            var databaseName = Guid.NewGuid().ToString();
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase(databaseName));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICountryRepository, CountryRepository>();

            services.AddScoped<ICountryService, CountryService>();

            ServiceProvider = services.BuildServiceProvider();

            DbContext = ServiceProvider.GetRequiredService<AppDbContext>();
            CountryService = ServiceProvider.GetRequiredService<ICountryService>();

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            var countries = new List<CountryModel>
            {
                new CountryModel { Id = 1, Name = "CountryA", Continent = "Europe" },
                new CountryModel { Id = 2, Name = "CountryB", Continent = "Asia" }
            };

            DbContext.Countries.AddRange(countries);
            DbContext.SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Database.EnsureDeleted();
            DbContext.Dispose();
            ServiceProvider.Dispose();
        }
    }
}
