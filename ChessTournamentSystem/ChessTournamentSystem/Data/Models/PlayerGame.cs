namespace ChessTournamentSystem.Data.Models
{
    public class PlayerGame
    {
        public int Id { get; set; }

        public string WinnerId { get; set; }
        public virtual Player Winner { get; set; }

        public string DefeatedId { get; set; }
        public virtual Player DefeatedPlayer { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
