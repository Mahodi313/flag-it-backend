using flag_it_backend.Models;
using flag_it_backend.Services.Interfaces;
using System.Threading.Tasks;
using Xunit;

namespace flag_it_backend.UnitTests.ServiceTests
{
    public class CountryServiceTesting : IClassFixture<CountryServiceFixture>
    {
        private readonly CountryServiceFixture _fixture;

        public CountryServiceTesting(CountryServiceFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task GetAll_ShouldReturnAllCountries()
        {
            var result = await _fixture.CountryService.GetAll();

            Assert.NotNull(result);
            Assert.Equal(2, result.Count); // There should be 2 countries in the list
        }

        [Fact]
        public async Task GetById_ShouldReturnCountry_WhenIdExists()
        {
            var result = await _fixture.CountryService.GetById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("CountryA", result.Name);
        }

        [Fact]
        public async Task GetById_ShouldThrowException_WhenIdDoesNotExist()
        {
            await Assert.ThrowsAsync<InvalidOperationException>(() => _fixture.CountryService.GetById(999));
        }

        [Fact]
        public async Task GetByName_ShouldReturnCountry_WhenNameExists()
        {
            var result = await _fixture.CountryService.GetByName("CountryA");

            Assert.NotNull(result);
            Assert.Equal("CountryA", result.Name);
        }

        [Fact]
        public async Task GetByName_ShouldThrowException_WhenNameDoesNotExist()
        {
            await Assert.ThrowsAsync<KeyNotFoundException>(() => _fixture.CountryService.GetByName("FakeCountry"));
        }

        [Fact]
        public async Task GetCountriesByContinent_ShouldReturnCountries_WhenContinentExists()
        {
            var result = await _fixture.CountryService.GetCountriesByContinent("Europe");

            Assert.NotNull(result);
            Assert.Single(result); // Europe should have 1 country
            Assert.Equal("CountryA", result[0].Name);
        }

        [Fact]
        public async Task GetCountriesByContinent_ShouldReturnEmptyList_WhenContinentDoesNotExist()
        {
            var result = await _fixture.CountryService.GetCountriesByContinent("NonExistentContinent");

            Assert.NotNull(result);
            Assert.Empty(result); // Should return an empty list
        }
    }
}
