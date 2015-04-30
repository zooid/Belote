namespace Belote.Models
{
    using System.Collections.Generic;

    public class Table
    {
        public Table()
        {
            this.Players = new List<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public User Creater { get; set; }

        public virtual IEnumerable<User> Players { get; set; }
    }
}
