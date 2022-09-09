using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EjercicioORM1JoelGramajo.Models;
using DbContext = System.Data.Entity.DbContext;

namespace EjercicioORM1JoelGramajo.Data
{
    public class EjercicioORMContext : DbContext
    {
        public EjercicioORMContext() : base("name=EjercicioORMContext")
        {

        }

        public DbSet<AsignarTarea> AsignarTarea { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<RegistroControl> RegistroControl { get; set; }
        public DbSet<RegistroIngresoSalida> RegistroIngresoSalida { get; set; }
        public DbSet<TipoControl> TipoControl { get; set; }
    }
}