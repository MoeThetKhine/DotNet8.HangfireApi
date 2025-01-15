using DotNet8.HangfireApi.Features.Blog;
using DotNet8.HangfireApi.Modelts;
using DotNet8.HangfireApi.Repositories.Blog;

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

        private static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            return services.AddScoped<IBlogRepository, BlogRepository>();
        }

        private static IServiceCollection AddBusinessLogicService(this IServiceCollection services)
        {
            return services.AddScoped<BL_Blog>();
        }
    }
}
