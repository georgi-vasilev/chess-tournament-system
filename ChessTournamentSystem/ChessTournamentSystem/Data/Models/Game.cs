namespace ChessTournamentSystem.Data.Models
{
    using System;

    public class Game
    {
        public int Id { get; set; }

        public string WinnerId { get; set; }
        public Player Winner { get; set; }

        public string LoserId { get; set; }
        public Player Loser { get; set; }

        public DateTime PlayDate { get; set; }

        public int MovesCount { get; set; }

        public TimeSpan GameDuration { get; set; }

        public int GameTypeId { get; set; }
        public GameType GameType { get; set; }
    }
}
