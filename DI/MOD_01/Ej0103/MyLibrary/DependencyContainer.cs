using MyLibrary;
namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddMyLibraryServices(
        this IServiceCollection services)
    {
        services.AddSingleton<IExampleService, ExampleService>()
            .AddOptions<ExampleOptions>();
        return services;
    }
}
