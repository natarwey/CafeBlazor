using CafeBlazor.ApiRequest.Model;

namespace CafeBlazor.ApiRequest.Services
{
    public class OrderService
    {
        private readonly HttpClient _http;

        public OrderService(HttpClient http) => _http = http;

        public async Task<List<Order>> GetOrders() =>
            await _http.GetFromJsonAsync<List<Order>>("api/Orders");

        // Добавьте другие методы
    }
}
