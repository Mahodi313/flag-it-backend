using flag_it_backend.Models;

namespace flag_it_backend.Services.Interfaces
{
    public interface IResultService
    {
        Task<List<ResultModel>> GetAllAsync();
        Task<ResultModel> GetByIdAsync(int id);
        Task<List<ResultModel>> GetByUserIdAsync(string userId);
        Task<ResultModel> CreateAsync(ResultModel result);
    }
}
