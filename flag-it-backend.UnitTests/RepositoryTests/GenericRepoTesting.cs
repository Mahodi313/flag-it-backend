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
    public class GenericRepoTesting : IDisposable
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

        // CREATE
        [Fact]
        public async Task CreateAsync_AddsEntityToDatabase()
        {
            CountryModel newEntity = new CountryModel { Id = 2, Name = "New Test Entity" };

            var result = await _repository.CreateAsync(newEntity);

            Assert.Equal(2, await _dbContext.Set<CountryModel>().CountAsync()); // Checks if there are now 2 entities (OBS! 1 is already created in the constructor)
            Assert.Equal("New Test Entity", result.Name); // Check that the name of the added entity is correct

            var entityInDb = await _dbContext.Set<CountryModel>().FindAsync(newEntity.Id);
            Assert.NotNull(entityInDb); // Checks that the entity was actually saved in the db
        }

        // READ BY ID
        [Fact]
        public async Task GetByIdAsync_ReturnsEntity()
        {
            var entity = await _repository.GetByIdAsync(1);

            Assert.NotNull(entity);
            Assert.Equal(1, entity.Id);
            Assert.Equal("Test Entity", entity.Name);
        }

        // READ(GET ALL)
        [Fact]
        public async Task GetAllAsync_ReturnsAllEntities()
        {
            var entities = await _repository.GetAllAsync();

            Assert.NotNull(entities);
            Assert.Single(entities); // Checks if there is only one entity in the list, since we only have 1 pre created
            Assert.Equal("Test Entity", entities.First().Name); // Checks if the first entity of the list is equal to the provided one
        }

        // DELETE
        [Fact]
        public async Task DeleteAsync_RemovesEntityFromDatabase()
        {
            var deletedEntity = await _repository.DeleteAsync(1);

            Assert.Equal(1, deletedEntity.Id); // Verify the ID of the deleted entity

            var entityInDb = await _dbContext.Set<CountryModel>().FindAsync(1);
            Assert.Null(entityInDb); // Checks if entity was removed from the db
        }

        // UPDATE
        [Fact]
        public async Task UpdateAsync_UpdatesEntityInDatabase()
        {
            var entityToUpdate = await _repository.GetByIdAsync(1);
            entityToUpdate.Name = "Updated Entity";

            await _repository.UpdateAsync(entityToUpdate);

            var updatedEntity = await _dbContext.Set<CountryModel>().FindAsync(1);
            Assert.NotNull(updatedEntity); // Checks if entity still exists
            Assert.Equal("Updated Entity", updatedEntity.Name); // Verifies that the name was updated
        }




        // Cleans up the environment after each test
        public void Dispose()
        {
            Console.WriteLine("Calling");
            _dbContext.Database.EnsureDeleted(); // Delete the in memory db
            _dbContext.Dispose(); // Dispose of the dbcontext
            _serviceProvider.Dispose(); // Dispose of the service provider
        }

    }
}
