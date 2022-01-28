namespace ChessTournamentSystem.Data.Models
{
    using ChessTournamentSystem.Data.Common;
    using System;
    using System.Collections.Generic;

    public class Tournament : IAuditInfo, IDeletableEntity
    {
        public Tournament()
        {
            this.Players = new HashSet<PlayerTournament>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Rank EloTarget { get; set; }

        public decimal ParticipationFee { get; set; }

        public decimal Prize { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<PlayerTournament> Players { get; set; }
    }
}
