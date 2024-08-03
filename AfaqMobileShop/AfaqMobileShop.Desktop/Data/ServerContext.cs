using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using AfaqMobileShop.Shared.Models;
using AfaqMobileShop.Shared.DTO;

namespace AfaqMobileShop.Desktop.Data
{
    public interface IServerContext
    {
        Task<List<Sell>> GetSalesAsync();
        Task<Sell> GetSaleAsync(int id);
        Task<bool> DeleteSellAsync(int id);
        Task<Sell> CreateSellAsync(Sell sell);
        Task<Sell> UpdateSellAsync(int id, Sell sell);
        Task<LoginResponseDTO> UserLogin(LoginDTO model);
        Task<List<Buy>> GetBuyersAsync();
        Task<Buy> GetBuyAsync(int id);
        Task<Buy> CreateBuyAsync(Buy buy);
        Task<Buy> UpdateBuyAsync(int id, Buy buy);
        Task<bool> DeleteBuyAsync(int id);
        Task<List<Stock>> GetStocksAsync();
        Task<Stock> GetStockAsync(int id);
        Task<Stock> CreateStockAsync(Stock stock);
        Task<Stock> UpdateStockAsync(int id, Stock stock);
        Task<bool> DeleteStockAsync(int id);
        Task<int> GetTotalQuantityStockAsync();
        Task<int> GetTotalSalesAsync();
        Task<int> GetTotalBuyersAsync();
        Task<APIResponseDTO> ChangePassword(ChangePasswordDTO model);
    }
    public class ServerContext : IServerContext
    {
        private readonly HttpClient _httpClient;
       /* public static string ServerBaseUrl = "https://localhost:7101/";*/
        public static string ServerBaseUrl = "http://localhost:2025/";

        public ServerContext(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<List<Sell>> GetSalesAsync()
        {
            
          
            var response = await _httpClient.GetAsync("api/sells");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Sell>>();

        }
        public async Task<Sell> CreateSellAsync(Sell sell)
        {

            var response = await _httpClient.PostAsJsonAsync("api/sells", sell);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Sell>();
        }

        public async Task<bool> DeleteSellAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/sells/{id}");
            response.EnsureSuccessStatusCode(); // Throw exception if not successful
            return response.IsSuccessStatusCode;
        }
        public async Task<Sell> GetSaleAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/sells/{id}");
            response.EnsureSuccessStatusCode(); // Throw exception if not successful
            return await response.Content.ReadFromJsonAsync<Sell>();
        }

        public async Task<Sell> UpdateSellAsync(int id, Sell sell)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/sells/{id}",sell);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Sell>();
        }

        public async Task<LoginResponseDTO> UserLogin(LoginDTO model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/user/login", model);
            if (response.IsSuccessStatusCode)
            {
                // Read the response content which should contain the token
                var Response = await response.Content.ReadFromJsonAsync<LoginResponseDTO>();

                // Extract and return the token
                return Response;
            }
           else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return new LoginResponseDTO()
                {
                    IsSuccess = false
                };
            }
            else
            {
                // Handle other types of errors
                throw new HttpRequestException($"Failed to login. Status code: {response.StatusCode}");
            }
        }

        public async Task<List<Buy>> GetBuyersAsync()
        {
            var response = await _httpClient.GetAsync("api/buys");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Buy>>();
        }

        public async Task<Buy> GetBuyAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/buys/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Buy>();
        }

        public async Task<Buy> CreateBuyAsync(Buy buy)
        {
            var response = await _httpClient.PostAsJsonAsync("api/buys", buy);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Buy>();
        }

        public async Task<Buy> UpdateBuyAsync(int id, Buy buy)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/buys/{id}", buy);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Buy>();
        }

        public async Task<bool> DeleteBuyAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/buys/{id}");
            response.EnsureSuccessStatusCode();
            return  response.IsSuccessStatusCode;
        }

        public async Task<List<Stock>> GetStocksAsync()
        {
            var response = await _httpClient.GetAsync("api/stocks");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Stock>>();
        }

        public async Task<Stock> GetStockAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/stocks/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Stock>();

        }

        public async Task<Stock> CreateStockAsync(Stock stock)
        {
            var response = await _httpClient.PostAsJsonAsync("api/stocks", stock);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Stock>();
        }

        public async Task<Stock> UpdateStockAsync(int id, Stock stock)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/stocks/{id}", stock);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Stock>();
        }

        public async Task<bool> DeleteStockAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/stocks/{id}");
            response.EnsureSuccessStatusCode();
            return response.IsSuccessStatusCode;
        }

        public async Task<int> GetTotalQuantityStockAsync()
        {
            var response = await _httpClient.GetAsync("api/stocks/totalstocks");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<int> GetTotalSalesAsync()
        {
            var response = await _httpClient.GetAsync("api/sells/totalselling");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> GetTotalBuyersAsync()
        {
            var response = await _httpClient.GetAsync("api/buys/totalbuying");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<APIResponseDTO> ChangePassword(ChangePasswordDTO model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/user/ChangePassword",model);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<APIResponseDTO>();
                
                return result;
            }
            return new APIResponseDTO
            {
                IsSuccess = false,
                Message = "Something went wrong please contact developers"
            };
        }
    }
}
