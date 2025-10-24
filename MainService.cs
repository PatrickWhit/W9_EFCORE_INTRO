using W9_EFCORE_INTRO.Data;
using W9_EFCORE_INTRO.Models;

namespace W6_SOLID_DIP
{
    public class MainService : IMainService
    {
        public void Execute()
        {
            Console.WriteLine("Entering MainService");

            var context = new GameContext();
            context.Seed();

            // Add a new room to the database
            var newRoom = new Room
            {
                Name = "Dungeon",
                Description = "A dark, damp dungeon with chains haining from the walls."
            };
            context.Rooms.Add(newRoom);

            // Add new character to database
            var newCharacter = new Character
            {
                Name = "Gorak the Feirce",
                Level = 10,
                Room = newRoom
            };
            context.Characters.Add(newCharacter);

            // Find a character by name
            var foundCharacter = context.Characters.FirstOrDefault(character => character.Name.Contains("Wizard"));
            Console.WriteLine($"Found character: {foundCharacter?.Name}, Level: {foundCharacter.Level}");

            // Not part of the assignment, but still important
            // delete a character
            var characterToDelete = context.Characters.FirstOrDefault(character => character.Name.Contains("Knight"));
            context.Characters.Remove(characterToDelete);
            Console.WriteLine($"Deleted character: {characterToDelete.Name}");

            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // !!!!! REMEMBER TO SAVE CHANGES !!!!!
            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            context.SaveChanges();
        }
    }
}