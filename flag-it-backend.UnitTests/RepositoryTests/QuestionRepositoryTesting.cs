using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories;
using flag_it_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace flag_it_backend.UnitTests.RepositoryTests
{
    public class QuestionRepositoryTesting : IDisposable
    {
        private IQuestionRepository _questionRepository;
        private AppDbContext _dbContext;
        private ServiceProvider _serviceProvider;

        public QuestionRepositoryTesting()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TestDb"));

            services.AddScoped<IQuestionRepository, QuestionRepository>();

            _serviceProvider = services.BuildServiceProvider();

            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            _questionRepository = _serviceProvider.GetRequiredService<IQuestionRepository>();

            SeedDatabase();
        }

        [Fact]
        public async Task GetQuestionByDifficultiesAsync_ReturnsCorrectQuestions()
        {
            var questions = await _questionRepository.GetQuestionByDifficultiesAsync("Easy");

            Assert.NotNull(questions);
            Assert.Equal(2, questions.Count); // 2 questions with "Easy" difficulty in the seeded data
            Assert.All(questions, q => Assert.Equal("Easy", q.Difficulty));
        }

        [Fact]
        public async Task GetQuestionByDifficultiesAsync_ReturnsEmptyList_WhenNoQuestionsFound()
        {
            var questions = await _questionRepository.GetQuestionByDifficultiesAsync("FakeDifficulty");

            Assert.NotNull(questions);
            Assert.Empty(questions); // Should return an empty list
        }

        [Fact]
        public async Task GetByCountryIdAsync_ReturnsCorrectQuestion()
        {
            var question = await _questionRepository.GetByCountryIdAsync(1);

            Assert.NotNull(question);
            Assert.Equal(1, question.CountryId);
        }

        [Fact]
        public async Task GetByCountryIdAsync_ReturnsNull_WhenQuestionNotFound()
        {
            var question = await _questionRepository.GetByCountryIdAsync(999);

            Assert.Null(question); // Should return null
        }

        private void SeedDatabase()
        {
            var questions = new List<QuestionModel>
            {
                new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 },
                new QuestionModel { Id = 2, Difficulty = "Medium", CountryId = 2 },
                new QuestionModel { Id = 3, Difficulty = "Easy", CountryId = 3 },
                new QuestionModel { Id = 4, Difficulty = "Hard", CountryId = 4 }
            };

            _dbContext.Questions.AddRange(questions);
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