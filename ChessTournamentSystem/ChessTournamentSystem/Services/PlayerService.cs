namespace ChessTournamentSystem.Services
{
    using ChessTournamentSystem.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class PlayerService<T> : IPlayerService<T>
    {
        public IEnumerable<T> All(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> All(Func<T, object> orderBy, bool descending = false)
        {
            throw new NotImplementedException();
        }

        public Task<T> Create()
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteById(int playerId)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteEntity(T player)
        {
            throw new NotImplementedException();
        }

        public int EnrollInTournamnet()
        {
            throw new NotImplementedException();
        }

        public bool Exists()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int playerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetEnrolledTournaments(T player)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update()
        {
            throw new NotImplementedException();
        }
    }
}
