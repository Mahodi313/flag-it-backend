using flag_it_backend.Models;

namespace flag_it_backend.Services.Interfaces
{
    public interface IQuestionService
    {
        public Task<List<QuestionModel>> GetAll();
        public Task<List<QuestionModel>> GetById(int id);
        public Task<QuestionModel> GetByDiffculty(string difficulty);
        public Task<QuestionModel> GetByCountryId(int countryId);
    }
}
