namespace MyLibrary.Interfaces
{
    public interface IReportServiceLifeTime
    {
        Guid Id { get; }
        ServiceLifetime Lifetime { get; }
    }
}
