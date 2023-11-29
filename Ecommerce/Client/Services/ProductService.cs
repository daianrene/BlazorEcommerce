using System.Net.Http.Json;

namespace Ecommerce.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result =
                await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts()
        {
            var results =
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");

            if (results != null && results.Data != null)
                Products = results.Data;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var results = categoryUrl == null ?
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");

            if (results != null && results.Data != null)
                Products = results.Data;

            ProductsChanged.Invoke();
        }
    }
}
