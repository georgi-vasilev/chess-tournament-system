namespace ChessTournamentSystem.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IPlayerService<T>
    {
        public bool Exists();

        public Task<T> Create();

        public Task<T> Update();

        public Task<T> DeleteById(int playerId);

        public Task<T> DeleteEntity(T player);

        public IEnumerable<T> All(Expression<Func<T, bool>> filter);

        public IEnumerable<T> All(Func<T, object> orderBy, bool descending = false);

        public Task<T> GetById(int playerId);

        public IEnumerable<T> GetEnrolledTournaments(T player);

        public int EnrollInTournamnet();
    }
}
