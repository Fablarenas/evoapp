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
        services.AddTransient<ContractController>();
        services.AddTransient<CupsController>();
        services.AddTransient<SimController>();
        services.AddTransient<UrmController>();
        services.AddTransient<UmController>();
        services.AddTransient<DeviceController>();


        services.AddTransient<Form1>();
        services.AddTransient<Group>();
        services.AddTransient<Client>();
        services.AddTransient<Cups>();
        services.AddTransient<Contract>();
        services.AddTransient<Cups>();
        services.AddTransient<Sim>();
        services.AddTransient<Device>();
        services.AddTransient<Urm>();
        services.AddTransient<Um>();
        // ... (otros registros)

        return services.BuildServiceProvider();
    }
}