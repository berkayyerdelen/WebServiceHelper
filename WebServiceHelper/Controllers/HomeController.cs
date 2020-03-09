using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Common.Attributes;
using Core.Domain.Project.Queries;
using Core.Domain.Project.Queries.Project;
using Core.Domain.Project.Queries.RestApi;
using Core.Domain.Project.Queries.RestApi.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebServiceHelper.ViewModel;

namespace WebServiceHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
            => (_logger,_mediator) = (logger,mediator);

        
        public IActionResult Index()
        {
            var projectdetails = _mediator.Send(new GetProjectDetailsQuery(),CancellationToken.None).Result;

            return View("Index",new ProjectViewModel()
            {
                projectViewModel= projectdetails
            });
        }
        [HttpGet]
        public IActionResult RestService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RestService(RestApiResponseDto t)
        {
            if (ModelState.IsValid)
            {
                var k = _mediator.Send(new RestApiQueryHandler(t), CancellationToken.None).Result;
                return View(k);
            }
            return View();
            
        }


    }
}
