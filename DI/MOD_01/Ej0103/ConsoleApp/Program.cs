using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyLibrary;

var Builder = Host.CreateApplicationBuilder();

Builder.Services.AddMyLibraryServices();

using IHost AppHost = Builder.Build();

IExampleService Service = AppHost.Services.GetRequiredService<IExampleService>();

Console.WriteLine();
Console.WriteLine("Press <enter> to finish.");
Console.ReadLine();
