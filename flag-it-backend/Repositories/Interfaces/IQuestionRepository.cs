using flag_it_backend.Models;

namespace flag_it_backend.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        public Task <List<QuestionModel>> GetQuestionByDifficultiesAsync (string difficulty);
        public Task<QuestionModel> GetByCountryIdAsync(int countryId);
    }
}
