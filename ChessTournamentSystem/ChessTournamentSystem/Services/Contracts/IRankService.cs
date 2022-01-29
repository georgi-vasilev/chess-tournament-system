namespace ChessTournamentSystem.Services.Contracts
{
    public interface IRankService<T>
    {
        public string GetRank(T player);

        public string PromoteRank(T player);

        public int GetRankPoints(T player);

    }
}
