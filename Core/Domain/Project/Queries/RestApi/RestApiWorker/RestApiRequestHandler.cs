
using Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto;
using Domain.Enums;
using MediatR;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utils.Converters;

namespace Core.Domain.Project.Queries.RestApi.RestApiWorker
{
    public class RestApiHandler : IRequestHandler<RestApiRequestDto, RestApiResponseDto>
    {
        
        public async Task<RestApiResponseDto> Handle(RestApiRequestDto request, CancellationToken cancellationToken)
        {
            var response = await RestApiResponse(request);
            return response;
        }

        #region Helper

        private Task<RestApiResponseDto> RestApiResponse(RestApiRequestDto request)
        {
            var httpType = (HttpType)request.HttpType;
            var methodType = EnumConverter.ConvertTo<HttpType, Method>(httpType);
            var client = new RestClient(request.ApiUrl);
            var reqType = new RestRequest(methodType);
            var restApiResponseDto = new RestApiResponseDto();
            Stopwatch sw = Stopwatch.StartNew();
            switch (httpType)
            {
                case HttpType.GET:

                    var contextGet = client.ExecuteAsync(reqType).Result;
                    sw.Stop();
                    restApiResponseDto.ProccessTime = sw.ElapsedMilliseconds.ToString();
                    restApiResponseDto.ApiURL = request.ApiUrl;
                    restApiResponseDto.HttpType = httpType;
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

        #endregion

    }

}
