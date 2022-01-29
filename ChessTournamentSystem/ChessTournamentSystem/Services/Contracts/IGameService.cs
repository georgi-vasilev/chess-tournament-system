namespace ChessTournamentSystem.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IGameService<T>
    {
        public Task<T> DefineWinner();

        public Task<int> GetPlayedMovesCountByPlayer(T player);

        public bool Exists();

        public Task<T> Create();

        public Task<T> Update();

        public Task<T> DeleteById(int gameId);

        public Task<T> DeleteEntity(T game);

        public IEnumerable<T> All(Expression<Func<T, bool>> filter);

        public IEnumerable<T> All(Func<T, object> orderBy, bool descending = false);

        public Task<T> GetById(int gameId);
    }
}
