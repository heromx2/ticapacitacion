namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindSalesServices(
        this IServiceCollection services,
        Action<DBOptions> configureDBOptions)
    {
        services
            .AddUseCasesServices()
            .AddRepositories()
            .AddDataContexts(configureDBOptions)
            .AddPresenters();

        return services;
    }
}
