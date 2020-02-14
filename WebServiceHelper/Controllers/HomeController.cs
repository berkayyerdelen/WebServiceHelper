using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebServiceHelper.Entities.Domains;
using WebServiceHelper.Models;
using WebServiceHelper.Services;

namespace WebServiceHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IRepository<Project> _projectRepository;
        public IRepository<WebApps> _webserviceRepository;
        public IRepository<WebAppDetails> _webservicedetailRepository;
        public HomeController(ILogger<HomeController> logger,
            IRepository<Project> projectRepository,
            IRepository<WebApps> webserviceRepository,
            IRepository<WebAppDetails> webservicedetailRepository)
        {
            _projectRepository = projectRepository;
            _webservicedetailRepository = webservicedetailRepository;
            _webserviceRepository = webserviceRepository;
        }

        public IActionResult Index()
        {
            var a =_projectRepository.GetAll().Result;
             
            return View(a);

        }

        public IActionResult Management()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
