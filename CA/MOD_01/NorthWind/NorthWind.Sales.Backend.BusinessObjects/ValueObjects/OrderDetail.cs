namespace NorthWind.Sales.Backend.BusinessObjects.ValueObjects;

public class OrderDetail(int productId, decimal unitPrice, short quantity)
{
    public int ProductId { get; } = productId;
    public decimal UnitPrice => unitPrice;
    public short Quantity => quantity;
}
