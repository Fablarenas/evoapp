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

        services.AddTransient<ClientsController>();
        services.AddTransient<GroupsController>();
        services.AddTransient<Form1>();
        services.AddTransient<Form2>();
        // ... (otros registros)

        return services.BuildServiceProvider();
    }
}