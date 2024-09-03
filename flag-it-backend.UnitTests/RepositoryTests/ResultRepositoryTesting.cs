using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories;
using flag_it_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace flag_it_backend.UnitTests.RepositoryTests
{
    public class ResultRepositoryTesting : IDisposable
    {
        private IResultRepository _resultRepository;
        private AppDbContext _dbContext;
        private ServiceProvider _serviceProvider;

        public ResultRepositoryTesting()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TestDb"));

            services.AddScoped<IResultRepository, ResultRepository>();

            _serviceProvider = services.BuildServiceProvider();

            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            _resultRepository = _serviceProvider.GetRequiredService<IResultRepository>();

            SeedDatabase();
        }

        [Fact]
        public async Task GetResultsByUserIdAsync_ReturnsCorrectResults()
        {
            var results = await _resultRepository.GetResultsByUserIdAsync("user1");

            Assert.NotNull(results);
            Assert.Equal(2, results.Count); // 2 results for user1 in the seeded data
            Assert.All(results, r => Assert.Equal("user1", r.UserId));
        }

        [Fact]
        public async Task GetResultsByUserIdAsync_ReturnsEmptyList_WhenNoResultsFound()
        {
            var results = await _resultRepository.GetResultsByUserIdAsync("fakeUser");

            Assert.NotNull(results);
            Assert.Empty(results); // Should return an empty list
        }

        private void SeedDatabase()
        {
            var results = new List<ResultModel>
            {
                new ResultModel { Id = 1, UserId = "user1", Points = 10, Difficulty = "Easy", DateOfResult = DateTime.Now, TimeOfCompletion = TimeSpan.FromMinutes(5) },
                new ResultModel { Id = 2, UserId = "user1", Points = 20, Difficulty = "Medium", DateOfResult = DateTime.Now, TimeOfCompletion = TimeSpan.FromMinutes(10) },
                new ResultModel { Id = 3, UserId = "user2", Points = 15, Difficulty = "Hard", DateOfResult = DateTime.Now, TimeOfCompletion = TimeSpan.FromMinutes(7) }
            };

            _dbContext.Results.AddRange(results);
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