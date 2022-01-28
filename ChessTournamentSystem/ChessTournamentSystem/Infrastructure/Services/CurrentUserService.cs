namespace ChessTournamentSystem.Infrastructure.Services
{
    using ChessTournamentSystem.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Http;
    using System.Security.Claims;

    public class CurrentUserService : ICurrentUserService
    {
        private readonly ClaimsPrincipal user;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
            => this.user = this.HttpContextAccessor?.HttpContext.User;

        public string GetId()
            => this.user?.GetId();

        public string GetUserName()
            => this.user?.Identity?.Name;
    }
}
