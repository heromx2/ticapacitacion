using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyLibrary;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            builder.Services.AddHostedService<Worker>();
            builder.Services.AddSingleton<Form1>();
            using IHost AppHost = builder.Build();
            AppHost.RunAsync();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(
                AppHost.Services.GetRequiredService<Form1>()
                );
        }
    }
}