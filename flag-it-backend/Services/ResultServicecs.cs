using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services.Interfaces;


namespace flag_it_backend.Services
{
    public class ResultService : IResultService
    {
        private readonly IGenericRepository<ResultModel> _resultRepository;
        private readonly IResultRepository _resultRepo2;

        public ResultService(IGenericRepository<ResultModel> resultRepository, IResultRepository resultRepo2)
        {
            _resultRepository = resultRepository;
            _resultRepo2 = resultRepo2;
        }

        public async Task<List<ResultModel>> GetAllAsync()
        {
            return await _resultRepository.GetAllAsync();
        }

        public async Task<ResultModel> GetByIdAsync(int id)
        {
            return await _resultRepository.GetByIdAsync(id);
        }

        public async Task<List<ResultModel>> GetByUserIdAsync(string userId)
        {
            return await _resultRepo2.GetResultsByUserIdAsync(userId);
        }

        public async Task<ResultModel> CreateAsync(ResultModel result)
        {
            return await _resultRepository.CreateAsync(result);
        }
    }
}
