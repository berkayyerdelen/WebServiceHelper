using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using MediatR;

namespace Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto
{
    public class RestApiResponseDto
    {
        public string ApiURL { get; set; }
        public string Token { get; set; }
        public HttpType HttpType { get; set; }
        public string Response { get; set; }
        public string ProccessStatus { get; set; }
        public string ProccessTime { get; set; }
    }
}
