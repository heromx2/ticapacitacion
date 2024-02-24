namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(
        this IServiceCollection services)
    {
        services.AddScoped<ICommandsReporitory, CommandsRepository>();

        return services;
    }
}

// TODO: Implementar el Presenter