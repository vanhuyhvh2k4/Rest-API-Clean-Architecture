
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rest_API_Clean_Architecture.Application.Common.Interfaces.Authentication;
using Rest_API_Clean_Architecture.Application.Common.Interfaces.Services;
using Rest_API_Clean_Architecture.Infrastructure.Authentication;
using Rest_API_Clean_Architecture.Infrastructure.Services;

namespace Rest_API_Clean_Architecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }
    }
}
