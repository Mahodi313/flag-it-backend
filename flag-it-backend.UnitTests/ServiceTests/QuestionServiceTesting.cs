using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services;
using Moq;

namespace flag_it_backend.UnitTests.ServiceTests
{
    public class QuestionServiceTesting
    {
        private readonly QuestionService _questionService;
        private readonly Mock<IGenericRepository<QuestionModel>> _questionRepoMock;
        private readonly Mock<IQuestionRepository> _questionRepo2Mock;

        public QuestionServiceTesting()
        {
            _questionRepoMock = new Mock<IGenericRepository<QuestionModel>>();
            _questionRepo2Mock = new Mock<IQuestionRepository>();
            _questionService = new QuestionService(_questionRepoMock.Object, _questionRepo2Mock.Object);
        }

        [Fact]
        public async Task GetAll_ShouldReturnAllQuestions()
        {
            // Arrange
            var questions = new List<QuestionModel> { new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 } };
            _questionRepoMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(questions);

            // Act
            var result = await _questionService.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(questions.Count, result.Count);
        }

        [Fact]
        public async Task GetById_ShouldReturnQuestion_WhenIdExists()
        {
            // Arrange
            var question = new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 };
            _questionRepoMock.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(question);

            // Act
            var result = await _questionService.GetById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
        }

        [Fact]
        public async Task GetById_ShouldThrowException_WhenIdDoesNotExist()
        {
            // Arrange
            _questionRepoMock.Setup(repo => repo.GetByIdAsync(999)).ThrowsAsync(new InvalidOperationException());

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() => _questionService.GetById(999));
        }

        [Fact]
        public async Task GetByDiffculty_ShouldReturnQuestions_WhenDifficultyExists()
        {
            // Arrange
            var questions = new List<QuestionModel> { new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 } };
            _questionRepo2Mock.Setup(repo => repo.GetQuestionByDifficultiesAsync("Easy")).ReturnsAsync(questions);

            // Act
            var result = await _questionService.GetByDiffculty("Easy");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(questions.Count, result.Count);
        }

        [Fact]
        public async Task GetByDiffculty_ShouldReturnEmptyList_WhenDifficultyDoesNotExist()
        {
            // Arrange
            _questionRepo2Mock.Setup(repo => repo.GetQuestionByDifficultiesAsync("FakeDifficulty")).ReturnsAsync(new List<QuestionModel>());

            // Act
            var result = await _questionService.GetByDiffculty("FakeDifficulty");

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetByCountryIdAsync_ShouldReturnQuestion_WhenCountryIdExists()
        {
            // Arrange
            var question = new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 };
            _questionRepo2Mock.Setup(repo => repo.GetByCountryIdAsync(1)).ReturnsAsync(question);

            // Act
            var result = await _questionService.GetByCountryIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.CountryId);
        }

        [Fact]
        public async Task GetByCountryIdAsync_ShouldReturnNull_WhenCountryIdDoesNotExist()
        {
            // Arrange
            _questionRepo2Mock.Setup(repo => repo.GetByCountryIdAsync(999)).ReturnsAsync((QuestionModel)null);

            // Act
            var result = await _questionService.GetByCountryIdAsync(999);

            // Assert
            Assert.Null(result);
        }
    }
}