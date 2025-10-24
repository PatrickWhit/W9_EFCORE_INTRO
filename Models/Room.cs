using System.Collections;

namespace W9_EFCORE_INTRO.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // nvigation property (foreign key)
        public virtual ICollection<Character> characters { get; set; } // one-to-many relationship
    }
}
