﻿namespace NorthWind.Sales.Backend.BusinessObjects.Aggregates;
public class OrderAggregate : Order
{
    readonly List<OrderDetail> OrderDetailsField = [];
    public IReadOnlyCollection<OrderDetail> OrderDetails => OrderDetailsField;
    public void AddDetail(int productId, decimal unitPrice, short quantity)
    {
        var ExistingOrderDetail = OrderDetailsField
            .FirstOrDefault(o => o.ProductId == productId);
        if (ExistingOrderDetail != default)
        {
            quantity += ExistingOrderDetail.Quantity;
            OrderDetailsField.Remove(ExistingOrderDetail);
        }
        OrderDetailsField.Add(
            new OrderDetail(productId, unitPrice, quantity));
    }

    public static OrderAggregate From(CreateOrderDto orderDto)
    {
        OrderAggregate OrderAggregate = new OrderAggregate
        {
            CustumerId = orderDto.CustomerId,
            ShipAddress = orderDto.ShipAddress,
            ShipCity = orderDto.ShipCity,
            ShipCountry = orderDto.ShipCountry,
            ShipPostalCode = orderDto.ShipPostalCode
        };

        foreach (var item in orderDto.OrderDetails)
        {
            OrderAggregate.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
        }
        return OrderAggregate;
    }
}
