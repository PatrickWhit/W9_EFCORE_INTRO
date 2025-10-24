namespace W9_EFCORE_INTRO.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        // navigation property (foreign key)
        //public int RoomId { get; set; }     // foreign key
        public virtual Room? Room { get; set; }      // foreign key
    }
}
