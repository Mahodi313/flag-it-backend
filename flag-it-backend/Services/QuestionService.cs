using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services.Interfaces;

namespace flag_it_backend.Services
{
    public class QuestionService : IQuestionService
    {
        public IGenericRepository<QuestionModel> _questionRepo { get; set; }
        public IQuestionRepository _questionRepo2 { get; set; }


        public QuestionService(IGenericRepository<QuestionModel> questionRepo, IQuestionRepository questionRepo2)
        {
            _questionRepo = questionRepo;
            _questionRepo2 = questionRepo2;
        }

        public Task<List<QuestionModel>> GetAll()
        {
            return _questionRepo.GetAllAsync();
        }
        public async Task<QuestionModel> GetById(int id)
        {
            return await _questionRepo.GetByIdAsync(id);
        }

        public async Task<List<QuestionModel>> GetByDiffculty(string difficulty)
        {
            return await _questionRepo2.GetQuestionByDifficultiesAsync(difficulty);
        }

        public async Task<QuestionModel> GetByCountryIdAsync(int countryId)
        {
            return await _questionRepo2.GetByCountryIdAsync(countryId);
        }
    }
}
