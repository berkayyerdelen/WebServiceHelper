using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Common.Attributes;
using Core.Domain.Project.Queries;
using Core.Domain.Project.Queries.Project;
using Core.Domain.Project.Queries.Project.ProjectDetails;
using Core.Domain.Project.Queries.Project.ProjectNames;
using Core.Domain.Project.Queries.RestApi;
using Core.Domain.Project.Queries.RestApi.RestApiWorker;
using Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebServiceHelper.ViewModel;

namespace WebServiceHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
            => (_logger, _mediator) = (logger, mediator);


        public IActionResult Index()
        {
            var projectdetails = _mediator.Send(new GetProjectDetailsQuery(), CancellationToken.None).Result;

            return View("Index", new ProjectViewModel()
            {
                projectViewModel = projectdetails
            });
        }
        [HttpGet]
        public IActionResult RestService()
        {
            var source = _mediator.Send(new GetProjectsQuery(), CancellationToken.None).Result.Select(x => new SelectListItem()
            {
                Value = x.ProjectId.ToString(),
                Text = x.ProjectName
            }).ToList();
            //var vm = new ProjectRestApiViewModel()
            //{
            //    Project = source
            //};
            return View("RestService", new ProjectRestApiViewModel()
            {
                Project = source
            });
        }

        [HttpPost]
        public IActionResult RestService(RestApiResponseDto request)
        {
            ModelState.Clear();
            var query = _mediator.Send(new RestApiQueryHandler(request), CancellationToken.None).Result;

            return View("RestService", new ProjectRestApiViewModel()
            {
                RestApiResponse = query

            });
        }


    }
}
