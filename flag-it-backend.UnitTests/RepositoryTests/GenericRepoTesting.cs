using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories;
using flag_it_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flag_it_backend.UnitTests.RepositoryTests
{
    public class GenericRepoTesting
    {
        private ServiceProvider _serviceProvider;
        private AppDbContext _dbContext;
        private IGenericRepository<CountryModel> _repository;

        public GenericRepoTesting()
        {

            // SETUP

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TestDb"));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            _serviceProvider = services.BuildServiceProvider();

            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            _repository = _serviceProvider.GetRequiredService<IGenericRepository<CountryModel>>();

            CountryModel testEntity = new CountryModel
            {
                Id = 1,
                Name = "Test Entity",
            };

            _dbContext.Set<CountryModel>().Add(testEntity);
            _dbContext.SaveChanges();
        }

        [Fact]
        public async Task CreateAsync_AddsEntityToDatabase()
        {
            CountryModel newEntity = new CountryModel { Id = 2, Name = "New Test Entity" };

            var result = await _repository.CreateAsync(newEntity);

            Assert.Equal(2, await _dbContext.Set<CountryModel>().CountAsync()); // Checks if there are now 2 entities (OBS! 1 is already created in the constructor).
            Assert.Equal("New Test Entity", result.Name); // Check that the name of the added entity is correct.

            var entityInDb = await _dbContext.Set<CountryModel>().FindAsync(newEntity.Id);
            Assert.NotNull(entityInDb); // Checks that the entity was actually saved in the db
        }

        // Cleans up the environment after each test
        public void Dispose()
        {
            _dbContext.Database.EnsureDeleted(); // Delete the in memory db
            _dbContext.Dispose(); // Dispose of the dbcontext
            _serviceProvider.Dispose(); // Dispose of the service provider
        }

    }
}
