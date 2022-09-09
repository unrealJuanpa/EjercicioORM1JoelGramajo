using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjercicioORM1JoelGramajo.Models
{
    public class DbContext
    {
        public DbContext()
        {

        }

        public DbSet <AsignarTarea> AsignarTarea { get; set; }
        public DbSet <Empleado> Empleado { get; set; }
        public DbSet <RegistroControl> RegistroControl { get; set; }
        public DbSet <RegistroIngresoSalida> RegistroIngresoSalida { get; set; }
        public DbSet <TipoControl> TipoControl { get; set; }

    }
}