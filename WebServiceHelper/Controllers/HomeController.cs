﻿using System;
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
        public IRepository<WebServices> _webserviceRepository;
        public IRepository<WebServiceDetails> _webservicedetailRepository;
        public HomeController(ILogger<HomeController> logger,
            IRepository<Project> projectRepository,
            IRepository<WebServices> webserviceRepository,
            IRepository<WebServiceDetails> webservicedetailRepository)
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

        public IActionResult Privacy()
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
