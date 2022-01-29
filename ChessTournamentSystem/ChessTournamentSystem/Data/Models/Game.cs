namespace ChessTournamentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Game
    {
        public Game()
        {
            this.Players = new HashSet<PlayerGame>();
        }

        public int Id { get; set; }

        public ICollection<PlayerGame> Players { get; set; }
        public DateTime PlayDate { get; set; }

        public int MovesCount { get; set; }

        public TimeSpan GameDuration { get; set; }

        public int GameTypeId { get; set; }
        public GameType GameType { get; set; }
    }
}
