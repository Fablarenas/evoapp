using Autofac;
using EvorodApp.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SqlServer.Server;
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

        return services.BuildServiceProvider();
    }

    private static void ConfigureContainer()
    {
        var builder = new ContainerBuilder();

        // Registro de dependencias
        builder.RegisterType<MiDbContext>().AsSelf().InstancePerLifetimeScope();
        builder.RegisterType<MiControlador>().AsSelf();
        builder.RegisterType<Form1>().AsSelf();
        builder.RegisterType<Form2>().AsSelf();
        // ... (otros registros)

        Container = builder.Build();
    }
}