using CafeBlazor.ApiRequest.Model;

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
            return await _httpClient.GetFromJsonAsync<List<Order>>("api/Orders");
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/Orders/{id}");
        }
    }
}
