namespace NorthWind.Sales.Backend.DataContext.EFCore.Services;
internal class NorthWindSalesCommandsDataContext(IOptions<DBOptions> options) :
    NorthWindSalesContext(options),
    INorthWindSalesCommandsDataContext
{
    public async Task AddOrderAsync(Order order) =>
        await AddAsync(order);

    public async Task AddOrderDetailsAsync(IEnumerable<OrderDetail> orderDetails) =>
        await AddRangeAsync(orderDetails);

    public async Task SaveChangesAsync() =>
        await base.SaveChangesAsync();
}
