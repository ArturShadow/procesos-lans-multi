using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Database;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace procesos_lans_mvc_aspnet.Controllers
{
    [Route("[controller]")]
    public class EmpleadoController : Controller
    {
        private readonly ILogger<EmpleadoController> _logger;
        private readonly LansContext _context;

        public EmpleadoController(ILogger<EmpleadoController> logger, LansContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // _context.
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}