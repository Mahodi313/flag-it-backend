using flag_it_backend.Controllers;
using flag_it_backend.DTOs;
using flag_it_backend.Models;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using static flag_it_backend.DTOs.ResultDtos;

namespace flag_it_backend.UnitTests.ControllerTests
{
    public class ResultControllerTesting
    {
        private readonly ResultController _controller;
        private readonly Mock<IResultService> _resultServiceMock;

        public ResultControllerTesting()
        {
            _resultServiceMock = new Mock<IResultService>();

            _controller = new ResultController(_resultServiceMock.Object);
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult()
        {
            // Arrange
            var results = new List<ResultModel>
            {
                new ResultModel { Id = 1, Points = 1 },
                new ResultModel { Id = 2, Points = 2 },
                new ResultModel { Id = 3, Points = 3 }
            };
            var resultDtos = results.Select(r => new ResultDtos.ResultDto
            {
                Points = r.Points,
                UserId = r.UserId,
                Difficulty = r.Difficulty,
                DateOfResult = r.DateOfResult,
                TimeOfCompletion = r.TimeOfCompletion
            }).ToList();

            _resultServiceMock.Setup(service => service.GetAllAsync()).ReturnsAsync(resultDtos);

            // Act
            var actionResult = await _controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var returnedResults = Assert.IsType<List<ResultDtos.ResultDto>>(okResult.Value);
            Assert.Equal(results.Count, returnedResults.Count);
        }

        [Fact]
        public async Task CreateTest()
        {
            // Arange
            var result = new CreateDto
            {
                Id = 1,
                DateOfResult = new DateTime()
            };
            _resultServiceMock.Setup(service => service.CreateAsync(result));

            //Act

            var actionResult = await _controller.Create(result);

            // Assert
            var okResult = Assert.IsType<OkResult>(actionResult);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public async Task GetByIDTest()
        {
            // Arange
            var result = new GetByIdDto
            {
                Id = 1,
            };
            _resultServiceMock.Setup(service => service.GetByIdAsync(1)).ReturnsAsync(result);

            //Act
            var resultById = await _controller.GetById(1);

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(resultById.Result);
            Assert.Equal(200, okResult?.StatusCode);
        }

        [Fact]
        public async Task GetByUserIDTest()
        {
            // Arrange
            string userId = "string";
            var expectedResults = new List<ResultDtos.ResultDto>
    {
            new ResultDtos.ResultDto { UserId = userId, DateOfResult = new DateTime() }
    };
            _resultServiceMock.Setup(service => service.GetByUserIdAsync(userId)).ReturnsAsync(expectedResults);

            // Act
            var actionResult = await _controller.GetByUserId(userId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            Assert.Equal(200, okResult.StatusCode);
            var returnedResults = Assert.IsType<List<ResultDtos.ResultDto>>(okResult.Value);
            Assert.Equal(expectedResults, returnedResults);
        }
    }
}
