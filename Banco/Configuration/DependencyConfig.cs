using Banco.Data;
using Banco.Data.Content;
using Banco.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Banco.Configuration;

public static class DependencyConfig
{
    public static void DependencyRegister(this IServiceCollection services)
    {
        //Repositorys
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<DbContext, BancoContext>();
    }
}
