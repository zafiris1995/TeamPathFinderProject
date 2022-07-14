using Project123;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Initializers
{
    public class MockupDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        
        protected override void Seed(ApplicationDbContext context)
        {
            #region GameSeeding

            Game g1 = new Game() { Title = "Fifa", Price = 10 };
            Game g2 = new Game() { Title = "Zelda", Price = 20 };
            Game g3 = new Game() { Title = "Tetris", Price = 30 };

            context.Games.AddOrUpdate(g1, g2, g3);
            context.SaveChanges();

            #endregion

            #region GenreSeeding

            Genre gen1 = new Genre() { Kind = "Action" };
            Genre gen2 = new Genre() { Kind = "Adventure" };
            Genre gen3 = new Genre() { Kind = "Puzzle" };
            Genre gen4 = new Genre() { Kind = "Role-Playing" };
            Genre gen5 = new Genre() { Kind = "Simulation" };
            Genre gen6 = new Genre() { Kind = "Strategy" };
            Genre gen7 = new Genre() { Kind = "Sports" };
            Genre gen8 = new Genre() { Kind = "MMO" };

            context.Genres.AddOrUpdate(gen1, gen2, gen3, gen4, gen5, gen6, gen7, gen8);
            context.SaveChanges();
            #endregion


        }


    }
}
