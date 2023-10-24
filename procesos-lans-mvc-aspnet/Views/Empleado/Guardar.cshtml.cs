using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace procesos_lans_mvc_aspnet.Views.Empleado
{
    public class Guardar : PageModel
    {
        private readonly ILogger<Guardar> _logger;

        public Guardar(ILogger<Guardar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}