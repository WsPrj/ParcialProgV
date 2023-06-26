using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalPV.Models;

namespace FinalPV.Data
{
    public class FinalPVContext : DbContext
    {
        public FinalPVContext (DbContextOptions<FinalPVContext> options)
            : base(options)
        {
        }

        public DbSet<FinalPV.Models.Socio> Socio { get; set; } = default!;

        public DbSet<FinalPV.Models.Pago> Pago { get; set; } = default!;
    }
}
