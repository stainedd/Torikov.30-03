using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Torikov.Models;

namespace Torikov.Data
{
    public class TorikovContext : DbContext
    {
        public TorikovContext (DbContextOptions<TorikovContext> options)
            : base(options)
        {
        }

        public DbSet<Torikov.Models.Movie> Movie { get; set; }
    }
}
