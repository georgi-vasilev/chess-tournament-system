namespace ChessTournamentSystem.Infrastructure.Extensions
{
    using ChessTournamentSystem.Data;
    using ChessTournamentSystem.Data.Models;
    using ChessTournamentSystem.Infrastructure.Filters;
    using ChessTournamentSystem.Infrastructure.Services;
    using ChessTournamentSystem.Services;
    using ChessTournamentSystem.Services.Contracts;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.IdentityModel.Tokens;
    using Microsoft.OpenApi.Models;
    using System.Text;

    public static class ServiceCollectionExtensions
    {

        public static AppSettings GetAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsConfiguration = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsConfiguration);
            var appSettings = appSettingsConfiguration.Get<AppSettings>();

            return appSettings;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
            => services
               .AddDbContext<ApplicationDbContext>(options => options
               .UseSqlServer(configuration.GetDefaultConnectionString()));

        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services
                .AddIdentity<ApplicationUser, ApplicationRole>(options =>
                {
                    options.Password.RequiredLength = 6;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }

        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, AppSettings appSettings)
        {
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            services
                .AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });

            return services;
        }

        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            services
                .AddTransient<IIdentityService, IdentityService>()
                .AddScoped<ICurrentUserService, CurrentUserService>();

            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Chess Tournament System",
                        Version = "v1",
                    });
            });

            return services;
        }

        public static void AddApiControllers(this IServiceCollection services)
            => services.AddControllers(options => options
                .Filters
                .Add<ModelOrNotFoundActionFilter>());

        // Configure cookies
        public static IServiceCollection AddCookies(this IServiceCollection services)
            => services.Configure<CookiePolicyOptions>(
                options =>
                {
                    options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });
    }
}
