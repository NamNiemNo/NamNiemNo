using BUS.IService;
using BUS.Service;
using DAL.Context;
using DAL.IRepository;
using DAL.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            var form1 = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICuaHangRepository, CuaHangRepository>();
            services.AddTransient<ICuaHangService, CuaHangService>();
            services.AddTransient<ITrungTamRepository, TrungTamRepository>();
            services.AddTransient<ITrungTamService, TrungTamService>();
            services.AddTransient<IThuCungRepository, ThuCungRepository>();


            services.AddTransient<DBContext>();
            services.AddTransient<Form1>();
        }
    }
}
