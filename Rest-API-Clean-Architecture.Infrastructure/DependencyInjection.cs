
using Microsoft.Extensions.DependencyInjection;

namespace Rest_API_Clean_Architecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services;
        }
    }
}
