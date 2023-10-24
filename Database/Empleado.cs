using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEmpleado { get; set; }
        public int Nombre { get; set; }
        

        /**
        * Foreign Key
        */
        public int idRol { get; set; }

        [ForeignKey(nameof(idRol))]
        public virtual Rol? Rol { get; set;}
    }
}