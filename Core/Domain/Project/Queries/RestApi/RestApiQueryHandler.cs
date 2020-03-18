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
                        var reqGet = new RestRequest(Method.GET);
                        var contextGet = client.ExecuteAsync(reqGet).Result;
                        restApiResponseDto.ApiURL = request.property.ApiURL;
                        restApiResponseDto.HttpType = request.property.HttpType;
                        restApiResponseDto.Token = request.property.Token ?? null;
                        restApiResponseDto.Response = contextGet.Content;
                        return Task.FromResult(restApiResponseDto);                                   

                    case HttpType.Post:
                        var reqPost = new RestRequest(Method.POST);
                        reqPost.RequestFormat = DataFormat.Json;
                        reqPost.AddJsonBody(request.property.Response);
                        var response = client.ExecuteAsync(reqPost).Result;
                        restApiResponseDto.ApiURL = request.property.ApiURL;

                        return Task.FromResult(restApiResponseDto);
                    case HttpType.Delete:
                        var reqDelete = new RestRequest(Method.DELETE);
                        var responseDelete = client.ExecuteAsync(reqDelete);
                        return null;
                    case HttpType.Put:
                        var reqPut = new RestRequest(Method.PUT);
                        reqPut.RequestFormat = DataFormat.Json;                    
                        reqPut.AddJsonBody(request.property.Response);
                        var responseUpdate = client.ExecuteAsync(reqPut);
                        return null;
                    default:
                        return null;
                }
            }
        }
    }
}
