using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bscitgroup.Models;

namespace bscitgroup.Models
{
    public class bscitgroupContext : DbContext
    {
        public bscitgroupContext (DbContextOptions<bscitgroupContext> options)
            : base(options)
        {
        }

        public DbSet<bscitgroup.Models.Persona> Persona { get; set; }

        public DbSet<bscitgroup.Models.Curso> Curso { get; set; }
    }
}
