namespace flag_it_backend.UnitTests.ControllerTests
{
    //public class ResultControllerTesting
    //{
    //    private readonly ResultController _controller;
    //    private readonly Mock<IResultService> _resultServiceMock;

//    public ResultControllerTesting()
//    {
//        _resultServiceMock = new Mock<IResultService>();

//        _controller = new ResultController(_resultServiceMock.Object);
//    }

//    [Fact]
//    public async Task GetAll_ReturnsOkResult()
//    {
//        // Arrange
//        var results = new List<ResultModel>
//            {
//                new ResultModel { Id = 1, Points = 1 },
//                new ResultModel { Id = 2, Points = 2 },
//                new ResultModel { Id = 3, Points = 3 }
//            };
//        _resultServiceMock.Setup(service => service.GetAllAsync()).ReturnsAsync(results);

//        // Act
//        var actionResult = await _controller.GetAll();

//        // Assert
//        var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
//        var returnedResults = Assert.IsType<List<ResultModel>>(okResult.Value);
//        Assert.Equal(results.Count, returnedResults.Count);
//}
//    }
//}
