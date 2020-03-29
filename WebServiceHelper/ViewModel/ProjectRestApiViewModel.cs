using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.Project.Queries.Project.ProjectNames;
using Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebServiceHelper.ViewModel
{
    public class ProjectRestApiViewModel
    {
        public RestApiResponseDto  RestApiResponse { get; set; }
        public List<SelectListItem> Project { get; set; }
    }
}
