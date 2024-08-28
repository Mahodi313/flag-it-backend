using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services.Interfaces;

namespace flag_it_backend.Services
{
    public class QuestionService : IQuestionService
    {
        public IGenericRepository<QuestionModel> _questionRepo { get; set; }

        public QuestionService(IGenericRepository<QuestionModel> questionRepo)
        {
            _questionRepo = questionRepo;
        }

        public Task<List<QuestionModel>> GetAll()
        {
            return _questionRepo.GetAllAsync();
        }

        public Task<QuestionModel> GetByCountryId(int countryId)
        {
            throw new NotImplementedException();
        }

        public Task<QuestionModel> GetByDiffculty(string difficulty)
        {
            throw new NotImplementedException();
        }

        public Task<List<QuestionModel>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
