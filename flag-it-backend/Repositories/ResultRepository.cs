using flag_it_backend.Data;
using flag_it_backend.DTOs;
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
        public async Task<List<ResultDtos.ResultDto>> GetResultsByUserIdAsync(string userId)
        {
            List<ResultModel> results = await _context.Results.Where(r => r.UserId == userId).ToListAsync();
            List<ResultDtos.ResultDto> resultDtos = results.Select(r => ConvertToDto(r)).ToList();
            return resultDtos;
        }

        private ResultDtos.ResultDto ConvertToDto(ResultModel resultModel)
        {
            return new ResultDtos.ResultDto
            {
                Points = resultModel.Points,
                UserId = resultModel.UserId,
                Difficulty = resultModel.Difficulty,
                DateOfResult = resultModel.DateOfResult,
                TimeOfCompletion = resultModel.TimeOfCompletion
            };
        }
    }
}
