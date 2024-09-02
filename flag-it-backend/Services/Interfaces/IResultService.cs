using static flag_it_backend.DTOs.ResultDtos;

namespace flag_it_backend.Services.Interfaces
{
    public interface IResultService
    {
        Task<List<ResultDto>> GetAllAsync();
        Task<GetByIdDto> GetByIdAsync(int id);
        Task<List<ResultDto>> GetByUserIdAsync(string userId);
        Task CreateAsync(CreateDto resultModel);
    }
}
