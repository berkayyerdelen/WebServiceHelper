using Core.Domain.Project.Queries.RestApi;
using System.Threading.Tasks;
using Core.Domain.Project.Queries.RestApi.RestApiWorker;
using Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto;

namespace Core.Common.RestSharper
{
    public interface IRestApiHelper
    {
        Task<RestApiResponseDto> RestApiResponse(RestApiQueryHandler request);
    }
}