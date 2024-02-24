namespace NorthWind.Sales.Backend.UseCases.CreateOrder;
internal class CreateOrderInteractor(
    ICreateOrderOutputPort outputPort,
    ICommandsReporitory reporitory) : ICreateOrderInputPort
{
    public async Task Handle(CreateOrderDto orderDto)
    {
        OrderAggregate Order = OrderAggregate.From(orderDto);
        await reporitory.CreateOrder(Order);
        await reporitory.SaveChanges();
        await outputPort.Handle(Order);
    }
}
