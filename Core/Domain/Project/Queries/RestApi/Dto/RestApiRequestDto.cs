using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Project.Queries.RestApi.Dto
{
    public class RestApiRequestDto:IRequest
    {
        public string ApiURL { get; set; }
        public string Token { get; set; }
        public HttpType HttpType { get; set; }
        public string Request { get; set; }
    }
}
