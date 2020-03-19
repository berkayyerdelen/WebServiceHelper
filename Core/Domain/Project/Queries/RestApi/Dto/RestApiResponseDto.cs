using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Project.Queries.RestApi.Dto
{
    public class RestApiResponseDto:IRequest
    {
        public string ApiURL { get; set; }
        public string Token { get; set; }
        public HttpType HttpType { get; set; }
        public string Response { get; set; }
        public string ProccessStatus { get; set; }
        public string ProccessTime { get; set; }
    }
}
