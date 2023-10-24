using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace procesos_lans_mvc_aspnet.Models.ViewModel
{
    public class EmpleadoViewModel
    {
        public int idEmpleado { get; set; }
        
        [Required]
        [Display(Name = "Nombre")]
        public String? Nombre { get; set; }
        
        [Required]
        [Display(Name = "Rol")]
        public int idRol { get; set; }
    }
}