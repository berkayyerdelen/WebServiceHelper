using Core.Common.RestSharper;
using Core.Domain.Project.Queries.RestApi.Dto;
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
            private readonly IRestApiHelper _restApiHelper;
            public Handler(IRestApiHelper restApiHelper)
            {
                _restApiHelper = restApiHelper;
            }
            public Task<RestApiResponseDto> Handle(RestApiQueryHandler request, CancellationToken cancellationToken)
            {
                
                var response = _restApiHelper.RestApiResponse(request);
               
                return response;
            }
        }
    }
}
