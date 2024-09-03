using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services;
using Moq;
using static flag_it_backend.DTOs.ResultDtos;

namespace flag_it_backend.UnitTests.ServiceTests
{
    public class ResultServiceTesting
    {
        private readonly ResultService _resultService;
        private readonly Mock<IGenericRepository<ResultModel>> _resultRepoMock;
        private readonly Mock<IResultRepository> _resultRepo2Mock;

        public ResultServiceTesting()
        {
            _resultRepoMock = new Mock<IGenericRepository<ResultModel>>();
            _resultRepo2Mock = new Mock<IResultRepository>();
            _resultService = new ResultService(_resultRepoMock.Object, _resultRepo2Mock.Object);
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllResults()
        {
            // Arrange
            var results = new List<ResultModel> { new ResultModel { Id = 1, Points = 10, UserId = "user1" } };
            _resultRepoMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(results);

            // Act
            var result = await _resultService.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(results.Count, result.Count);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnResult_WhenIdExists()
        {
            // Arrange
            var resultModel = new ResultModel { Id = 1, Points = 10, UserId = "user1" };
            _resultRepoMock.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(resultModel);

            // Act
            var result = await _resultService.GetByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(10, result.Points);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldThrowException_WhenIdDoesNotExist()
        {
            // Arrange
            _resultRepoMock.Setup(repo => repo.GetByIdAsync(999)).ThrowsAsync(new InvalidOperationException());

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() => _resultService.GetByIdAsync(999));
        }

        [Fact]
        public async Task GetByUserIdAsync_ShouldReturnResults_WhenUserIdExists()
        {
            // Arrange
            var results = new List<ResultDto> { new ResultDto { Points = 10, UserId = "user1" } };
            _resultRepo2Mock.Setup(repo => repo.GetResultsByUserIdAsync("user1")).ReturnsAsync(results);

            // Act
            var result = await _resultService.GetByUserIdAsync("user1");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(results.Count, result.Count);
        }

        [Fact]
        public async Task GetByUserIdAsync_ShouldReturnEmptyList_WhenUserIdDoesNotExist()
        {
            // Arrange
            _resultRepo2Mock.Setup(repo => repo.GetResultsByUserIdAsync("fakeUser")).ReturnsAsync(new List<ResultDto>());

            // Act
            var result = await _resultService.GetByUserIdAsync("fakeUser");

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task CreateAsync_ShouldCreateResult()
        {
            // Arrange
            var createDto = new CreateDto
            {
                Points = 10,
                UserId = "user1",
                Difficulty = "Easy",
                DateOfResult = DateTime.Now,
                TimeOfCompletion = TimeSpan.FromMinutes(5)
            };

            // Act
            await _resultService.CreateAsync(createDto);

            // Assert
            _resultRepoMock.Verify(repo => repo.CreateAsync(It.IsAny<ResultModel>()), Times.Once);
        }
    }
}