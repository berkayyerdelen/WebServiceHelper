using Core.Domain.Project.Queries.RestApi;
using Core.Domain.Project.Queries.RestApi.Dto;
using Domain.Enums;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Utils.Converters;

namespace Core.Common.RestSharper
{
    public class RestApiHelper : IRestApiHelper
    {
       
       
        public Task<RestApiResponseDto> RestApiResponse(RestApiQueryHandler request)
        {
            
            var methodType = EnumConverter.ConvertTo<HttpType, Method>(request.property.HttpType);
            var client = new RestClient(request.property.ApiURL);
            var reqType = new RestRequest(methodType);
            var restApiResponseDto = new RestApiResponseDto();
            Stopwatch sw = Stopwatch.StartNew();


            switch (request.property.HttpType)
            {
                case HttpType.GET:
                    
                    var contextGet = client.ExecuteAsync(reqType).Result;
                    sw.Stop();
                    restApiResponseDto.ProccessTime = sw.ElapsedMilliseconds.ToString();
                    restApiResponseDto.ApiURL = request.property.ApiURL;
                    restApiResponseDto.HttpType = request.property.HttpType;
                    restApiResponseDto.Token = request.property.Token ?? null;
                    restApiResponseDto.Response = contextGet.Content;
                    restApiResponseDto.ProccessStatus = contextGet.StatusCode.ToString();
                   
                    return Task.FromResult(restApiResponseDto);

                case HttpType.POST:
                    Stopwatch.StartNew();
                    reqType.RequestFormat = DataFormat.Json;
                    reqType.AddJsonBody(request.property.Response);
                    var response = client.ExecuteAsync(reqType).Result;
                    
                    restApiResponseDto.ApiURL = request.property.ApiURL;

                    return Task.FromResult(restApiResponseDto);
                case HttpType.DELETE:
                   
                    var responseDelete = client.ExecuteAsync(reqType);
                    return null;
                case HttpType.PUT:
                   
                    reqType.AddJsonBody(request.property.Response);
                    var responseUpdate = client.ExecuteAsync(reqType);
                    return null;
                default:
                    return null;
            }
        }
    }
}
