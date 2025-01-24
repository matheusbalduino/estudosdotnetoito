using Microsoft.EntityFrameworkCore;
using ProEventos.Persistence.Data;

namespace ProEventos.API.Configurations;

public static class ConfigurationServices
{
    public static void ConfigurationContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(
           context => context.UseNpgsql(configuration.GetConnectionString("Default"))
        );
    }
}