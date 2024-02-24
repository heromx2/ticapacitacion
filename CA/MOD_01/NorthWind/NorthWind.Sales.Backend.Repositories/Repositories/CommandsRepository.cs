﻿namespace NorthWind.Sales.Backend.Repositories.Repositories;
internal class CommandsRepository(INorthWindSalesCommandsDataContext context) :
    ICommandsReporitory
{
    public async Task CreateOrder(OrderAggregate order)
    {
        await context.AddOrderAsync(order);
        await context.AddOrderDetailsAsync(
            order.OrderDetails
            .Select(d => new Entities.OrderDetail
            {
                Order = order,
                ProductId = d.ProductId,
                Quantity = d.Quantity,
                UnitPrice = d.UnitPrice
            }).ToArray());
    }

    public async Task SaveChanges() => 
        await context.SaveChangesAsync();
}
