using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjercicioORM1JoelGramajo.Models
{
    [Table("RegistroIngresoSalida")]

    public class RegistroIngresoSalida
    {
        [Key]
        [Required]
        public int IdRegistro { get; set; }

        public ICollection<Empleado> TablaEmpleado { get; set; }

        [Required]
        public DateTime FechaHoraIngreso { get; set; }

        [Required]
        public DateTime FechaHoraSalida { get; set; }

    }
}