using Microsoft.Extensions.DependencyInjection;
using System;

namespace POSManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<Main>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add your services here
            services.AddTransient<IMainStoreAccess, MainStoreAccess>();
            services.AddTransient<ISqlAccess, SqlAccess>(); // Assuming SqlAccess also has its dependencies
            services.AddTransient<Main>(); // Your WinForms main form
        }
    }
}