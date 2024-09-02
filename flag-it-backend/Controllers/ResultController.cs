using flag_it_backend.Models;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static flag_it_backend.DTOs.ResultDtos;

namespace flag_it_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly IResultService _resultService;

        // Constructor to inject the service dependency
        public ResultController(IResultService resultService)
        {
            _resultService = resultService;
        }

        // GET: api/Result
        // This method retrieves all results from the service.
        [HttpGet]
        public async Task<ActionResult<List<ResultModel>>> GetAll()
        {
            try
            {
                var results = await _resultService.GetAllAsync();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Result
        // This method creates a new result in the service.
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateDto resultModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Create the result asynchronously in the service
                await _resultService.CreateAsync(resultModel);
                // Return the created result with a CreatedAtAction (201) status code
                // The CreatedAtAction method is used to return a reference to the newly created resource
                return Ok()/*CreatedAtActi(nameof(GetById), new { id = resultModel.Id }, resultModel)*/;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Result/{id}
        // This method retrieves a result by its ID from the service.
        [HttpGet("{id}")]
        public async Task<ActionResult<ResultModel>> GetById(int id)
        {
            try
            {
                var result = await _resultService.GetByIdAsync(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Result/user/{userId}
        // This method retrieves results by UserId from the service.
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<List<ResultModel>>> GetByUserId(string userId)
        {
            try
            {
                // Fetch results by UserId asynchronously from the service
                var results = await _resultService.GetByUserIdAsync(userId);
                // Return the results with an OK (200) status code
                return Ok(results);
            }
            catch (Exception ex)
            {
                // Return a BadRequest (400) status code with the exception message in case of an error
                return BadRequest(ex.Message);
            }
        }
    }
}

