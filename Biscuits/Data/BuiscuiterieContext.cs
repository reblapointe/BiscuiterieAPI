using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biscuiterie.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Buiscuiterie.Data
{
    public class BuiscuiterieContext : IdentityDbContext<IdentityUser>
    {
        public BuiscuiterieContext (DbContextOptions<BuiscuiterieContext> options)
            : base(options)
        {
        }

        public DbSet<Biscuiterie.Models.Biscuit> Biscuit { get; set; } = default!;
    }
}
