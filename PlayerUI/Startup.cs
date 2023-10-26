using Autofac;
using EvorodApp.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SqlServer.Server;
using PlayerUI;
using System.ComponentModel;
using TestEvolutiaWorker.Infraestructure.Data;

public class Startup
{
    public ServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EVOROD;User Id=sa;Password=12345;TrustServerCertificate=true;Encrypt=False;");
        });

        services.AddScoped<ClientsController>();
        services.AddScoped<GroupsController>();

        services.AddScoped<Form1>();
        services.AddScoped<Group>();
        services.AddScoped<Client>();
        services.AddScoped<Cups>();
        services.AddScoped<Contract>();
        services.AddScoped<Cups>();
        services.AddScoped<Sim>();
        services.AddScoped<Device>();
        services.AddScoped<Urm>();
        services.AddScoped<Um>();
        // ... (otros registros)

        return services.BuildServiceProvider();
    }
}