using Core.Domain.Project.Queries.RestApi;
using Core.Domain.Project.Queries.RestApi.Dto;
using System.Threading.Tasks;

namespace Core.Common.RestSharper
{
    public interface IRestApiHelper
    {
        Task<RestApiResponseDto> RestApiResponse(RestApiQueryHandler request);
    }
}