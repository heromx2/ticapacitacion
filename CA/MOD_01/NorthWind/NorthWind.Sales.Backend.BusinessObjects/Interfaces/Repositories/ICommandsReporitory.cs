namespace NorthWind.Sales.Backend.BusinessObjects.Interfaces.Repositories;
public interface ICommandsReporitory : IUnitOfWork
{
    Task CreateOrder(OrderAggregate order);
}
