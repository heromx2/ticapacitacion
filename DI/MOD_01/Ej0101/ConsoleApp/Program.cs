using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyLibrary;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

//Builder.Services.AddSingleton<IMessageWriter, LoggingMesaggeWriter>();
//Builder.Services.AddSingleton<IMessageWriter, MessageWriter>();

Builder.Services.AddHostedService<Worker>();


Builder.Services.AddLogging(config =>
{
    config.ClearProviders();
    config.AddDebug();
    config.AddConsole();
});

using IHost AppHost = Builder.Build();

AppHost.Run();

// TODO : Utilizar la API de registro de sucesos integrada (ILogger)

/*
 * akfa MessageWriter
 * dfas
 */
