namespace Belote.Models
{
    using System;
    using System.Collections.Generic;

    public class Game
    {
        public Game()
        {
            this.FirstTeam = new List<User>();
            this.SecondTeam = new List<User>();
        }

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? FinishedOn { get; set; }

        public int FirstTeamScore { get; set; }

        public int SecondTeamScore { get; set; }

        public virtual IEnumerable<User> FirstTeam { get; set; }

        public virtual IEnumerable<User> SecondTeam { get; set; }    
    }
}
