using Core.Domain.Project.Queries.RestApi.Dto;
using Domain.Enums;
using MediatR;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Domain.Project.Queries.RestApi
{
    public class RestApiQueryHandler : IRequest<RestApiResponseDto>
    {
        public RestApiResponseDto property { get; set; }
        public RestApiQueryHandler(RestApiResponseDto _property)
        {
            property = _property;
        }
        public class Handler : IRequestHandler<RestApiQueryHandler, RestApiResponseDto>
        {

            public  Task<RestApiResponseDto> Handle(RestApiQueryHandler request, CancellationToken cancellationToken)
            {
                var client = new RestClient(request.property.ApiURL);
                var deserial = new JsonDeserializer();
                var restApiResponseDto = new RestApiResponseDto();
                switch (request.property.HttpType)
                {
                    case HttpType.Get:
                        var req = new RestRequest(Method.GET);
                        var context = client.ExecuteAsync(req).Result;
                        restApiResponseDto.ApiURL = request.property.ApiURL;
                        restApiResponseDto.HttpType = request.property.HttpType;
                        restApiResponseDto.Token = request.property.Token ?? null;
                        restApiResponseDto.Response = context.Content;
                        return Task.FromResult(restApiResponseDto);                                   

                    case HttpType.Post:
                        return null;
                    case HttpType.Delete:
                        return null;
                    case HttpType.Put:
                        return null;
                    default:
                        return null;
                }
            }
        }
    }
}
