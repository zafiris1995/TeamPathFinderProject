using MyDatabase.Initializers;
using Project123;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Sindesmos")
        {
            Database.SetInitializer<ApplicationDbContext>(new MockupDbInitializer());
            Database.Initialize(false);
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}
