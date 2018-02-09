using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace bscitgroup.Models
{
    public class bscitgroupContext : DbContext
    {
        public bscitgroupContext (DbContextOptions<bscitgroupContext> options)
            : base(options)
        {
        }

        public DbSet<bscitgroup.Models.Persona> Persona { get; set; }
        public DbSet<bscitgroup.Models.Categorias> Categorias { get; set; }
        public DbSet<bscitgroup.Models.PersonaServicioDetalle> PersonaServicioDetalle { get; set; }
        public DbSet<bscitgroup.Models.Servicio> Servicio { get; set; }
        public DbSet<bscitgroup.Models.ServicioDetalle> ServicioDetalle { get; set; }





    }
}
