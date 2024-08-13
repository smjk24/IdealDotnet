using Microsoft.Extensions.DependencyInjection;

namespace LinkTin.Data.Helpers
{
    public static class DependencyInjections
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<Token>();
        }
    }
}
