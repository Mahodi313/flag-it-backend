using flag_it_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flag_it_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        //Behöver en service 
        public QuestionController()
        {

        }


        [HttpGet]
        public async Task<ActionResult<List<QuestionModel>>> GetAll()
        {

        }


        // Get ById
        [HttpGet("GetById/{id}")]

        public async Task<ActionResult<List<QuestionModel>>> GetById(int id)
            {

            }


        // Get By Difficulty
        [HttpGet("GetByDifficulty/{difficulty}")]
        public async Task<ActionResult<List<QuestionModel>>> GetByDiffculty(string difficulty)
        {

        }




        // get Question by CountryId 
        [HttpGet("GetBycountryId/{countryId}")]
        public async Task<ActionResult<List<QuestionModel>>> GetByCountryId(int countryId )
        {

        }



    }
}
