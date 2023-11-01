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
            options.UseSqlServer("Server=PORTAPOL\\SQLEXPRESS;Database=EVOROD;User Id=sa;Password=pauli2165;TrustServerCertificate=true;Encrypt=False;");
        });

        services.AddTransient<ClientsController>();
        services.AddTransient<GroupsController>();
        services.AddTransient<ContractController>();
        services.AddTransient<CupsController>();
        services.AddTransient<SimController>();
        services.AddTransient<UrmController>();
        services.AddTransient<UmController>();
        services.AddTransient<DeviceController>();


        services.AddTransient<MainForm>();
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