using MyDatabase;
using Project123;
using RepositoryServices.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance
{
    public class GameRepository : IGameRepository
    {
        public ApplicationDbContext db;
        public DbSet<Game> games;

        public GameRepository(ApplicationDbContext context)
        {
            db = context;
            games = db.Set<Game>();
        }

        public IEnumerable<Game> GetAll()
        {
            return games.ToList();
        }
    }
}
