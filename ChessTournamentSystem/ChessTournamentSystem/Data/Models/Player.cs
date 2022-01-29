namespace ChessTournamentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Player : ApplicationUser
    {
        public Player()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Wins = new HashSet<PlayerGame>();
            this.Defeats = new HashSet<PlayerGame>();
            this.Tournaments = new HashSet<PlayerTournament>();
        }

        public ICollection<PlayerTournament> Tournaments { get; set; }

        [InverseProperty("Winner")]
        public ICollection<PlayerGame> Wins { get; set; }

        [InverseProperty("DefeatedPlayer")]
        public ICollection<PlayerGame> Defeats { get; set; }

        public int RankId { get; set; }

        public Rank Rank { get; set; }
    }
}
