using Core.Common.RestSharper;
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
    public class RestApiQueryHandler : IRequestHandler<RestApiRequestDto, RestApiResponseDto>
    {
        private readonly IRestApiHelper _restApiHelper;
        public RestApiQueryHandler(IRestApiHelper restApiHelper)
        {
            _restApiHelper = restApiHelper;
        }

        public async Task<RestApiResponseDto> Handle(RestApiRequestDto request, CancellationToken cancellationToken)
        {
            var response = await _restApiHelper.RestApiResponse(request);
            return response;
        }
    }
}
