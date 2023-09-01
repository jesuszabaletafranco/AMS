using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AMS.Models;

namespace AMS.Controllers
{
    public class AuditoriaController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AuditoriaController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GestionDocumental()
        {
            return View();
        }

        public IActionResult GestionMedica()
        {
            return View();
        }

        public IActionResult GestionJuridica()
        {
            return View();
        }

        public IActionResult GestionFinanciera()
        {
            return View();
        }

        public IActionResult Informes()
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
