using flag_it_backend.Models;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flag_it_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CountryModel>>> Get()
        {
            try
            {
                List<CountryModel> countries = await _countryService.GetAll();
                return Ok(countries);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByContinent/{continent}")]
        public async Task<ActionResult<List<CountryModel>>> Get(string continent)
        {
            try
            {
                List<CountryModel> countries = await _countryService.GetCountriesByContinent(continent);
                return Ok(countries);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<CountryModel>> GetById(int id)
        {
            try
            {
                CountryModel country = await _countryService.GetById(id);
                return Ok(country);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByName/{name}")]
        public async Task<ActionResult<CountryModel>> GetByName(string name)
        {
            try
            {
                CountryModel country = await _countryService.GetByName(name);
                return Ok(country);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
