namespace ChessTournamentSystem.Infrastructure.Services
{
    public interface ICurrentUserService
    {
        string GetId();

        string GetUserName();
    }
}
