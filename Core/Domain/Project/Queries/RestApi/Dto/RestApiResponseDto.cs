﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Core.Domain.Project.Queries.RestApi.Dto
{
    public class RestApiResponseDto
    {
        public string ApiURL { get; set; }
        public string Token { get; set; }
        public HttpType HttpType { get; set; }
        public string Request { get; set; }
    }
}