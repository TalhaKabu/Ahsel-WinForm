using Ahsel.Winform.Connection;
using Ahsel.Winform.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Ahsel.Winform
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            CreateHostBuilder();

            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
        }

        private static void CreateHostBuilder()
        {
            var host = Host.CreateDefaultBuilder()
               .ConfigureServices((context, services) =>
               {
                   services
                        .AddTransient<FrmMain>()

                        .AddSingleton<IGeneralDal, GeneralDal>()
                        
                        .AddSingleton<IConnectionConfiguration>(c =>
                        {
                            var configuration = c.GetService<IConfiguration>();
                            var connectionConfiguration = new ConnectionConfiguration();
                            configuration.Bind("ConnectionStrings", connectionConfiguration);
                            return connectionConfiguration;
                        });
               }).Build();

            ServiceProvider = host.Services;
        }
    }
}