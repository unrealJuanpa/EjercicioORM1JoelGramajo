using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjercicioORM1JoelGramajo.Models
{
    [Table("AsignarTarea")]
    public class AsignarTarea
    {
        [Key]
        [Required]
        public int IdAsignarTarea { get; set; }

        public ICollection<Empleado> TablaEmpleado { get; set; }

        [Required]
        [MaxLength(120)]
        public string NombreTarea { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}