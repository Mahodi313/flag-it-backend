using flag_it_backend.Models;
using flag_it_backend.Repositories.Interfaces;
using flag_it_backend.Services.Interfaces;
using static flag_it_backend.DTOs.ResultDtos;


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

        public async Task<List<ResultDto>> GetAllAsync()
        {
            List<ResultModel> resultModels = await _resultRepository.GetAllAsync();
            List<ResultDto> resultDtos = new List<ResultDto>();

            foreach (ResultModel resultModel in resultModels)
            {
                ResultDto resultDto = ConvertToDto(resultModel);
                resultDtos.Add(resultDto);
            }

            return resultDtos;
        }

        public async Task<GetByIdDto> GetByIdAsync(int id)
        {
            ResultModel resultModel = await _resultRepository.GetByIdAsync(id);
            GetByIdDto resultDto = ConvertToGetByIdDto(resultModel);
            return resultDto;
        }

        public async Task<List<ResultDto>> GetByUserIdAsync(string userId)
        {
            return await _resultRepo2.GetResultsByUserIdAsync(userId);
        }

        public async Task CreateAsync(CreateDto result)
        {
            ResultModel resultModel = new ResultModel();

            // Map the properties from ResultDtos to ResultModel
            resultModel.Points = result.Points;
            resultModel.UserId = result.UserId;
            resultModel.Difficulty = result.Difficulty;
            resultModel.DateOfResult = result.DateOfResult;
            resultModel.TimeOfCompletion = result.TimeOfCompletion;


            // Call the CreateAsync method of _resultRepository with the converted ResultModel object
            await _resultRepository.CreateAsync(resultModel);
        }

        private ResultDto ConvertToDto(ResultModel resultModel)
        {
            ResultDto resultDto = new ResultDto();

            resultDto.Points = resultModel.Points;
            resultDto.UserId = resultModel.UserId;
            resultDto.Difficulty = resultModel.Difficulty;
            resultDto.DateOfResult = resultModel.DateOfResult;
            resultDto.TimeOfCompletion = resultModel.TimeOfCompletion;

            return resultDto;
        }

        private GetByIdDto ConvertToGetByIdDto(ResultModel resultModel)
        {
            GetByIdDto resultDto = new GetByIdDto();

            resultDto.Points = resultModel.Points;
            resultDto.UserId = resultModel.UserId;
            resultDto.Difficulty = resultModel.Difficulty;
            resultDto.DateOfResult = resultModel.DateOfResult;
            resultDto.TimeOfCompletion = resultModel.TimeOfCompletion;

            return resultDto;
        }
    }
}
