namespace ChessTournamentSystem.Infrastructure.Extensions
{
    using ChessTournamentSystem.Data.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;

    public static class IdentityExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user
            .Claims
            .FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)
            ?.Value;

        public static ApplicationUser FindByEmail(this IEnumerable<ApplicationUser> users, string email)
            => users.FirstOrDefault(u => u.Email == email);

    }
}
