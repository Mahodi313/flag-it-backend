using flag_it_backend.Controllers;
using flag_it_backend.Models;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace flag_it_backend.UnitTests.ControllerTests
{
    public class QuestionControllerTesting
    {
        private readonly QuestionController _controller;
        private readonly Mock<IQuestionService> _questionServiceMock;

        public QuestionControllerTesting()
        {
            _questionServiceMock = new Mock<IQuestionService>();
            _controller = new QuestionController(_questionServiceMock.Object);
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult()
        {
            // Arrange
            var questions = new List<QuestionModel> { new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 } };
            _questionServiceMock.Setup(service => service.GetAll()).ReturnsAsync(questions);

            // Act
            var result = await _controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<QuestionModel>>(okResult.Value);
            Assert.Equal(questions.Count, returnValue.Count);
        }

        [Fact]
        public async Task GetById_ReturnsOkResult()
        {
            // Arrange
            var question = new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 };
            _questionServiceMock.Setup(service => service.GetById(1)).ReturnsAsync(question);

            // Act
            var result = await _controller.GetById(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<QuestionModel>(okResult.Value);
            Assert.Equal(question.Id, returnValue.Id);
        }

        [Fact]
        public async Task GetByDifficulty_ReturnsOkResult()
        {
            // Arrange
            var questions = new List<QuestionModel> { new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 } };
            _questionServiceMock.Setup(service => service.GetByDiffculty("Easy")).ReturnsAsync(questions);

            // Act
            var result = await _controller.GetByDiffculty("Easy");

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<QuestionModel>>(okResult.Value);
            Assert.Equal(questions.Count, returnValue.Count);
        }

        [Fact]
        public async Task GetByCountryId_ReturnsOkResult()
        {
            // Arrange
            var question = new QuestionModel { Id = 1, Difficulty = "Easy", CountryId = 1 };
            _questionServiceMock.Setup(service => service.GetByCountryIdAsync(1)).ReturnsAsync(question);

            // Act
            var result = await _controller.GetByCountryId(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<QuestionModel>(okResult.Value);
            Assert.Equal(question.Id, returnValue.Id);
        }
    }
}