using AlphaTechBank.Repository.Data;
using AlphaTechBank.UI.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;

namespace AlphaTechBank.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IConfiguration Configuration;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            //var connect = Configuration.GetConnectionString("Default");
            ServiceCollection services = new ServiceCollection();
            //Add Services here
            services.AddTransient<Form1>();
            services.AddDbContext<DataBaseContext>(options=>options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AlphaTechBankDb;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
            services.ConfigureUnitOfWork();
            services.ConfigureServiceManager();

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var form1 = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
    }
}