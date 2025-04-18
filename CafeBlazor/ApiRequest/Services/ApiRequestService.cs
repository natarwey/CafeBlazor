using CafeBlazor.ApiRequest.Model;
using System.Text.Json;

namespace CafeBlazor.ApiRequest.Services
{
    public class ApiRequestService
    {
        private readonly HttpClient _httpClient;

        public ApiRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Order>>("api/Orders")
                       ?? new List<Order>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading orders: {ex}");
                return new List<Order>();
            }
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/Orders/{id}");
        }

        public async Task<int> CreateOrderAsync(OrderCreateDto order)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Orders", order);
            return await response.Content.ReadFromJsonAsync<int>();
        }
    }
}
