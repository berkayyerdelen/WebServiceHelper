using Core.Domain.Project.Queries.RestApi;
using Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto;
using Domain.Enums;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Project.Queries.RestApi.RestApiWorker;
using Core.Interface.EntityFramework;
using Domain.Entities;
using Utils.Converters;

namespace Core.Common.RestSharper
{
    public class RestApiHelper :IRestApiHelper
    {
        private readonly IApplicationDbContext _context;

        public RestApiHelper(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<RestApiResponseDto> RestApiResponse(RestApiRequestDto request)
        {
            
            var methodType = EnumConverter.ConvertTo<HttpType, Method>(request.HttpType);
            var client = new RestClient(request.ApiUrl);
            var reqType = new RestRequest(methodType);
            var restApiResponseDto = new RestApiResponseDto();
            Stopwatch sw = Stopwatch.StartNew();
            switch (request.HttpType)
            {
                case HttpType.GET:
                    
                    var contextGet = client.ExecuteAsync(reqType).Result;
                    sw.Stop();
                    restApiResponseDto.ProccessTime = sw.ElapsedMilliseconds.ToString();
                    restApiResponseDto.ApiURL = request.ApiUrl;
                    restApiResponseDto.HttpType = request.HttpType;
                    restApiResponseDto.Token = request.Token ?? null;
                    restApiResponseDto.Response = contextGet.Content;
                    restApiResponseDto.ProccessStatus = contextGet.StatusDescription;
                    if (contextGet.IsSuccessful)
                    {
                     
                    }
                    return Task.FromResult(restApiResponseDto);

                case HttpType.POST:
                    Stopwatch.StartNew();
                    //reqType.RequestFormat = DataFormat.Json;
                    //reqType.AddJsonBody(request.Response);
                    //var response = client.ExecuteAsync(reqType).Result;
                    
                    //restApiResponseDto.ApiURL = request.ApiUrl;

                    return Task.FromResult(restApiResponseDto);
                case HttpType.DELETE:
                   
                    var responseDelete = client.ExecuteAsync(reqType);
                    return null;
                case HttpType.PUT:
                   
                    //reqType.AddJsonBody(request.Response);
                    //var responseUpdate = client.ExecuteAsync(reqType);
                    return null;
                default:
                    return null;
            }
        }

       
    }
}
