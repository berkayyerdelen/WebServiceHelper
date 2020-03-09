using Core.Domain.Project.Queries.RestApi.Dto;
using Domain.Enums;
using MediatR;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Domain.Project.Queries.RestApi
{
    public class RestApiQueryHandler : IRequest<RestApiResponseDto>
    {
        public string ApiURL { get; set; }
        public string Token { get; set; }
        public HttpType HttpType { get; set; }
        public string Request { get; set; }
        public class Handler : IRequestHandler<RestApiQueryHandler, RestApiResponseDto>
        {

            public Task<RestApiResponseDto> Handle(RestApiQueryHandler request, CancellationToken cancellationToken)
            {
                var client = new RestClient(request.ApiURL);
                switch (request.HttpType)
                {
                    case HttpType.Get:
                        
                    case HttpType.Post:
                        
                    case HttpType.Delete:
                        
                    case HttpType.Put:
                        
                    default:
                        break;
                }
            }
        }
    }
}
