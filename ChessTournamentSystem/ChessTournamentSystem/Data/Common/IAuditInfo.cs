namespace ChessTournamentSystem.Data.Common
{
    using System;

    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
