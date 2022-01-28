namespace ChessTournamentSystem.Services.Contracts
{
    public interface IIdentityService
    {
        string GenerateJwtToken(string userId, string userName, string secret);
    }
}
