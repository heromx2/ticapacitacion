using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyLibrary;

var Builder = Host.CreateApplicationBuilder();

Builder.Services.AddSingleton<ExampleService>();
Builder.Services.AddOptions<ExampleOptions>();//soporte@mail.ticapacitacion.com <-- correo de Miguel para preguntas

using IHost A = Builder.Build();

ExampleService service = A.Services.GetRequiredService<ExampleService>();

Console.WriteLine();
Console.WriteLine("Press <nter>");
Console.ReadLine();
