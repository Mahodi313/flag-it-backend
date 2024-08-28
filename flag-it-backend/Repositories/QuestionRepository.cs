using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace flag_it_backend.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public AppDbContext _context { get; set; }

        public QuestionRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<QuestionModel>> GetQuestionByDifficultiesAsync(string difficulty)
        {
            // Add questiones with a specific difficulty to a list
            List<QuestionModel> questions = await _context.Questions.Where(q => q.Difficulty == difficulty).ToListAsync();
            // Return the list
            return questions;
        }

        public async Task<QuestionModel?> GetByCountryIdAsync(int countryId)
        {
            return await _context.Questions.FirstOrDefaultAsync(q => q.CountryId == countryId);
        }
    }
}
