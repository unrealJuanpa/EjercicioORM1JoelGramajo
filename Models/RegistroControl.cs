using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjercicioORM1JoelGramajo.Models
{
    [Table("RegistroControl")]

    public class RegistroControl
    {
        [Key]
        [Required]
        public int IdRegistroControl { get; set; }

        public ICollection<Empleado> TablaEmpleado { get; set; }
        public ICollection<TipoControl> TablaTipoControl { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Informacion { get; set; }
    }
}