namespace NorthWind.Sales.Frontend.BussinessObjects.interfaces
{
    public interface ICreateOrderGateway
    {
        Task<int> CreateOrderAsync(CreateOrderDto order);
    }
}
