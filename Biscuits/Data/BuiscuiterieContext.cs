using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biscuiterie.Models;

namespace Buiscuiterie.Data
{
    public class BuiscuiterieContext : DbContext
    {
        public BuiscuiterieContext (DbContextOptions<BuiscuiterieContext> options)
            : base(options)
        {
        }

        public DbSet<Biscuiterie.Models.Biscuit> Biscuit { get; set; } = default!;
    }
}
