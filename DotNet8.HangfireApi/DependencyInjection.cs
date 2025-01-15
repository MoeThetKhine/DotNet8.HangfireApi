using DotNet8.HangfireApi.Modelts;

namespace DotNet8.HangfireApi
{
    public static class DependencyInjection
    {
        private static IServiceCollection AddDbContextService(
            this IServiceCollection services,
            WebApplicationBuilder builder
        )
        {
            builder.Services.AddDbContext<AppDbContext>(
                opt =>
                {
                    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
                },
                ServiceLifetime.Transient
            );

            return services;
        }
    }
}
