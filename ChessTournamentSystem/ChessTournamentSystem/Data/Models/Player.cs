namespace ChessTournamentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Player : ApplicationUser
    {
        public Player()
        {
            this.Id = Guid.NewGuid().ToString();
            this.GamesPlayed = new HashSet<Game>();
            this.Tournaments = new HashSet<PlayerTournament>();
        }

        public decimal Rating { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public int Draws { get; set; }

        public ICollection<Game> GamesPlayed { get; set; }

        public ICollection<PlayerTournament> Tournaments { get; set; }

        public int RankId { get; set; }
    }
}
