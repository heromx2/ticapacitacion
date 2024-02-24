namespace NorthWind.Sales.Frontend.WebApiGateways;
internal class CreateOrderGateway(HttpClient client) : ICreateOrderGateway
{
    public async Task<int> CreateOrderAsync(CreateOrderDto order)
    {
        int OrderId = 0;

        var Response = await client.PostAsJsonAsync(Endpoints.CreateOrder, order);
        if (Response.IsSuccessStatusCode)
        {
            OrderId = await Response.Content.ReadFromJsonAsync<int>();
        }

        return OrderId;
    }
}
