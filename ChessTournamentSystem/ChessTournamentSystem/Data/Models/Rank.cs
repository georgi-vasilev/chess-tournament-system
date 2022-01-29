namespace ChessTournamentSystem.Data.Models
{
    public class Rank
    {
        public int Id { get; set; }

        public int LowerBound { get; set; }

        public int UpperBound { get; set; }

        public string RankName { get; set; }

        public int PlayerRating { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }

    }
}
