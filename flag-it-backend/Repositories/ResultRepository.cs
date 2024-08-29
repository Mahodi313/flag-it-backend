using flag_it_backend.Data;
using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace flag_it_backend.Repositories

{

    public class ResultRepository : IResultRepository
    {
        public AppDbContext _context { get; set; }

        public ResultRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ResultModel>> GetResultsByUserIdAsync(string userId)
        {
            List<ResultModel> results = await _context.Results.Where(r => r.UserId == userId).ToListAsync();
            return results;
        }
    }
}
