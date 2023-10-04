
using Microsoft.Extensions.DependencyInjection;
using Rest_API_Clean_Architecture.Application.Services.Authentication;

namespace Rest_API_Clean_Architecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
