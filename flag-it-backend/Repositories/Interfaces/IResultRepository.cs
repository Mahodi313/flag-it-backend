using flag_it_backend.Models;

namespace flag_it_backend.Repositories.Interfaces
{
    public interface IResultRepository
    {
        public Task<List<ResultModel>> GetResultsByUserIdAsync(string userId);

    }
}
