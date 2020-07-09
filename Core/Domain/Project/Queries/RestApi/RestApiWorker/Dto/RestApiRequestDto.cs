using Domain.Enums;
using MediatR;

namespace Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto
{
    public class RestApiRequestDto:IRequest<RestApiResponseDto>
    {
        public string ApiUrl { get; set; }
        public string Token { get; set; }
        public HttpType HttpType { get; set; }

    }
}