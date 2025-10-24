using Microsoft.EntityFrameworkCore;
using W9_EFCORE_INTRO.Models;

namespace W9_EFCORE_INTRO.Data
{
    internal class GameContext : DbContext
    {
        public DbSet<Character> Characters { get; set; } // treat like a list
        public DbSet<Room> Rooms { get; set; } // treat like a list

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Server=bitsql.wctc.edu;Database=GameDb_10022_pwhitney;User Id=pwhitney;Password=000587623;
            // Server=(localdb)\\MSSQLLocalDB;Database=StartingEFCore;Trusted_Connection=True;
            optionsBuilder.UseSqlServer("Server=bitsql.wctc.edu;Database=GameDb_10022_pwhitney;User Id=pwhitney;Password=000587623;");
        }
        
        public void Seed()
        {
            if (!Rooms.Any())
            {
                var room1 = new Room { Name = "Entrance Hall", Description = "The main entry." };
                var room2 = new Room { Name = "Treasure Room", Description = "A room filled with treasures." };

                var character1 = new Character { Name = "Knight", Level = 1, Room = room1 };
                var character2 = new Character { Name = "Wizard", Level = 2, Room = room2 };

                Rooms.AddRange(room1, room2);
                Characters.AddRange(character1, character2);

                SaveChanges();
            }
        }
    }
}
