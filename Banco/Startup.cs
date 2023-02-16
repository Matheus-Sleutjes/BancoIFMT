using Banco.Configuration;

namespace Banco;

public class Startup
{
    public Startup(IHostEnvironment hostEnvironment)
    {
        var builder = new ConfigurationBuilder()
               .SetBasePath(hostEnvironment.ContentRootPath)
               .AddJsonFile("appsettings.json", true, true)
               .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", true, true)
               .AddEnvironmentVariables();
        builder.Build();
        
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.DatabaseRegister();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.DependencyRegister();

        services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.DatabaseRegister();

        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(config =>
        {
            config.AllowAnyOrigin();
            config.AllowAnyHeader();
            config.AllowAnyMethod();
        });

        app.UseStaticFiles();

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
        });
    }
}
