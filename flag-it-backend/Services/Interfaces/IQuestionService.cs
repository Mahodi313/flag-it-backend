using flag_it_backend.Models;

namespace flag_it_backend.Services.Interfaces
{
    public interface IQuestionService
    {
        public Task<List<QuestionModel>> GetAll();
        public Task<QuestionModel> GetById(int id);
        public Task<List<QuestionModel>> GetByDiffculty(string difficulty);
        public Task<QuestionModel> GetByCountryIdAsync(int countryId);
    }
}
