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

        public IActionResult Index(CancellationToken ct)
        {
            var a = _mediator.Send(new GetProjectDetailsQuery(),ct).Result;
           
            return View();
        }

        public IActionResult Management()
        {
            return View();
        }


    }
}
