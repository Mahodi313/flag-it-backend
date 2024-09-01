using flag_it_backend.Controllers;
using flag_it_backend.Models;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flag_it_backend.UnitTests.ControllerTests
{
    public class CountryControllerTesting
    {
        private readonly CountryController _controller;
        private readonly Mock<ICountryService> _countryServiceMock;

        public CountryControllerTesting()
        {
            _countryServiceMock = new Mock<ICountryService>();

            _controller = new CountryController(_countryServiceMock.Object);
        }

        [Fact]
        public async Task Get_ShouldReturnOk_WithListOfCountries()
        {

            var countries = new List<CountryModel>
            {
                new CountryModel { Id = 1, Name = "CountryA", Continent = "Europe" },
                new CountryModel { Id = 2, Name = "CountryB", Continent = "Asia" }
            };
            _countryServiceMock.Setup(service => service.GetAll()).ReturnsAsync(countries);

            var result = await _controller.Get();

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCountries = Assert.IsType<List<CountryModel>>(okResult.Value);
            Assert.Equal(2, returnCountries.Count);
        }

        [Fact]
        public async Task Get_ShouldReturnBadRequest_OnException()
        {

            _countryServiceMock.Setup(service => service.GetAll()).ThrowsAsync(new Exception("Some error"));

            var result = await _controller.Get();

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
            Assert.Equal("Some error", badRequestResult.Value);
        }

        [Fact]
        public async Task GetByContinent_ShouldReturnOk_WithListOfCountries()
        {

            var countries = new List<CountryModel>
            {
                new CountryModel { Id = 1, Name = "CountryA", Continent = "Europe" }
            };
            _countryServiceMock.Setup(service => service.GetCountriesByContinent("Europe")).ReturnsAsync(countries);

            var result = await _controller.GetByContinent("Europe");

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCountries = Assert.IsType<List<CountryModel>>(okResult.Value);
            Assert.Single(returnCountries);
        }

        [Fact]
        public async Task GetByContinent_ShouldReturnBadRequest_OnException()
        {

            _countryServiceMock.Setup(service => service.GetCountriesByContinent(It.IsAny<string>()))
                               .ThrowsAsync(new Exception("Some error"));

            var result = await _controller.GetByContinent("Europe");

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
            Assert.Equal("Some error", badRequestResult.Value);
        }

        [Fact]
        public async Task GetById_ShouldReturnOk_WithCountry()
        {

            var country = new CountryModel { Id = 1, Name = "CountryA", Continent = "Europe" };
            _countryServiceMock.Setup(service => service.GetById(1)).ReturnsAsync(country);

            var result = await _controller.GetById(1);

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCountry = Assert.IsType<CountryModel>(okResult.Value);
            Assert.Equal(1, returnCountry.Id);
        }

        [Fact]
        public async Task GetById_ShouldReturnBadRequest_OnException()
        {
            _countryServiceMock.Setup(service => service.GetById(It.IsAny<int>())).ThrowsAsync(new Exception("Some error"));

            var result = await _controller.GetById(1);

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
            Assert.Equal("Some error", badRequestResult.Value);
        }

        [Fact]
        public async Task GetByName_ShouldReturnOk_WithCountry()
        {
            var country = new CountryModel { Id = 1, Name = "CountryA", Continent = "Europe" };
            _countryServiceMock.Setup(service => service.GetByName("CountryA")).ReturnsAsync(country);

            var result = await _controller.GetByName("CountryA");

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCountry = Assert.IsType<CountryModel>(okResult.Value);
            Assert.Equal(1, returnCountry.Id);
        }

        [Fact]
        public async Task GetByName_ShouldReturnBadRequest_OnException()
        {
            _countryServiceMock.Setup(service => service.GetByName(It.IsAny<string>())).ThrowsAsync(new Exception("Some error"));

            var result = await _controller.GetByName("CountryA");

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
            Assert.Equal("Some error", badRequestResult.Value);
        }
    }
}
