using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjercicioORM1JoelGramajo.Models
{
    [Table("TipoControl")]

    public class TipoControl
    {
        [Key]
        [Required]
        public int IdTipoControl { get; set; }

        [Required]
        [MaxLength(120)]
        public string NombreControl { get; set; }
    }
}