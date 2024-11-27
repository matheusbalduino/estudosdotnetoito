using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;

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