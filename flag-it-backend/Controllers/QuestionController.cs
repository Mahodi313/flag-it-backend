using flag_it_backend.Models;
using flag_it_backend.Services;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace flag_it_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        //Behöver en service 
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }


        [HttpGet]
        public async Task<ActionResult<List<QuestionModel>>> GetAll()
        {
            try
            {
                List<QuestionModel> questions = await _questionService.GetAll();
                return Ok(questions);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // Get ById
        [HttpGet("GetById/{id}")]

        public async Task<ActionResult<QuestionModel>> GetById(int id)
        {
            try
            {
                QuestionModel question = await _questionService.GetById(id);
                return Ok(question);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // Get By Difficulty
        [HttpGet("GetByDifficulty/{difficulty}")]
        public async Task<ActionResult<List<QuestionModel>>> GetByDiffculty(string difficulty)
        {
            try
            {
                List<QuestionModel> questions = await _questionService.GetByDiffculty(difficulty);
                return Ok(questions);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // get Question by CountryId 
        [HttpGet("GetBycountryId/{countryId}")]
        public async Task<ActionResult<List<QuestionModel>>> GetByCountryId(int countryId)
        {
            try
            {
                QuestionModel question = await _questionService.GetByCountryIdAsync(countryId);
                    return Ok(question);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
