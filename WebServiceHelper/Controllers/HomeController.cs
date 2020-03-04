using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Project.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
           
            return View(projectdetails);
        }

        public IActionResult Management()
        {
            return View();
        }


    }
}
