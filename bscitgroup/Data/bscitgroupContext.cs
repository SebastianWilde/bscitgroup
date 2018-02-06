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
    }
}
