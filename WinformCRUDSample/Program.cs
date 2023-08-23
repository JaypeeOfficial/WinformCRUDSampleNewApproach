using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Security.Cryptography.X509Certificates;

namespace WinformCRUDSample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IHost host = Host.CreateDefaultBuilder(args)              
                    .ConfigureServices((context, services) =>
                    {
                        const string ML_CONNECTION_STRING = "DevConnection";
                    services.AddDbContext<StoreContext>(options =>
                    {
                        options.UseSqlServer(context.Configuration.GetConnectionString(ML_CONNECTION_STRING));
                    }, ServiceLifetime.Singleton);
                    services.AddSingleton<IHeroRepository, HeroRepository>();
                    services.AddSingleton<frmHero>();
                    }).Build();

            var form = host.Services.GetService<frmHero>();

            Application.Run(form);

        }
    }
}