using static flag_it_backend.DTOs.ResultDtos;

namespace flag_it_backend.Repositories.Interfaces
{
    public interface IResultRepository
    {
        public Task<List<ResultDto>> GetResultsByUserIdAsync(string userId);

    }
}
