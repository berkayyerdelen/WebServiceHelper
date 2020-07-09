using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Project.Queries.Project.ProjectDetails;
using Core.Domain.Project.Queries.Project.ProjectDetails.Dto;
using Core.Domain.Project.Queries.Project.ProjectNames;
using Core.Domain.Project.Queries.RestApi.RestApiWorker.Dto;
using Core.Domain.Project.Queries.WebApps;
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


        public async Task<IActionResult> Index()
        {
            var projectdetails = await _mediator.Send(new GetProjectDetailsRequest(), CancellationToken.None);

            return View("Index", new ProjectViewModel()
            {
                projectViewModel = projectdetails
            });
        }

        #region RestService




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
        public async Task<IActionResult> RestService(RestApiRequestDto request)
        {

            var query = await _mediator.Send(request, CancellationToken.None);

            return View("RestService", new ProjectRestApiViewModel()
            {
                RestApiResponse = query

            });
        }

        public async Task<JsonResult> GetWebApps(int productId)
        {
            var source = await _mediator.Send(new GetWebAppQuery(productId));
            return Json(source);
        }

        #endregion

    }
}
