using Banco.Data;
using Microsoft.EntityFrameworkCore;

namespace Banco.Configuration;

public static class DataBaseConfig
{
    public static void DatabaseRegister(this IServiceCollection services)
    {
        services.AddDbContext<BancoContext>(options => options.UseNpgsql("Host=localhost;Database=banco-ifmt;Username=postgres;Password=admin"));
    }
    public static void DatabaseRegister(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
        var gmContext = serviceScope.ServiceProvider.GetRequiredService<BancoContext>();
        gmContext.Database.Migrate();
    }
}
