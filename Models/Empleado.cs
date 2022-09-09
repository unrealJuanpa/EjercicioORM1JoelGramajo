using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;


namespace EjercicioORM1JoelGramajo.Models
{
    [Table("Empleado")]

    public class Empleado
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }

        [Required]
        public int Telefono { get; set; }

        [Required]
        [StringLength(120)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(120)]
        public string Contrasenia { get; set; }

        [Required]
        public DateTime FechaContratacion { get; set; }

        [Required]
        public float Salario { get; set; }

        [Required]
        [StringLength(120)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(18)]
        public string DPI { get; set; }

        [Required]
        [StringLength(120)]
        public string Puesto { get; set; }

        [Required]
        [StringLength(120)]
        public string Estado { get; set; }
    }
}