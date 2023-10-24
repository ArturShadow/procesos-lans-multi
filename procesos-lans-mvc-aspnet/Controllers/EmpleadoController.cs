using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Database;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using procesos_lans_mvc_aspnet.Models.ViewModel;

namespace procesos_lans_mvc_aspnet.Controllers
{
    [Route("[controller]")]
    public class EmpleadoController : Controller
    {
        private readonly LansContext _context;

        public EmpleadoController(LansContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var empleados = _context.Empleados.Include(e => e.Rol).ToList();
            return View(empleados);
        }

        public IActionResult Guardar()
        {
            var roles = new SelectList(_context.Roles.ToList(), "idRol", "Nombre");
            ViewData["roles"] = roles;
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(EmpleadoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var roles = new SelectList(_context.Roles.ToList(), "idRol", "Nombre");
                ViewData["roles"] = roles;
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}