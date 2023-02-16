using Banco;
using Microsoft.AspNetCore;

public static class Program
{
    public static string? stringConection = "";
    public static void Main(string[] args)
    {
        GetStringConection(args);
        CreateWebHostBuilder(args).Build().Run();
    }
    public static IWebHostBuilder CreateWebHostBuilder(string[] args)=>
                                  WebHost.CreateDefaultBuilder(args)
                                    .UseStartup<Startup>();
    public static void GetStringConection(string[] args)
    {
        stringConection = WebApplication.CreateBuilder(args).Configuration.GetConnectionString("DefaultConnection");
    }
}