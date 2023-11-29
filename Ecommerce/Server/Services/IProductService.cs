namespace Ecommerce.Server.Services
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsList();
        Task<ServiceResponse<Product>> GetProduct(int productId);

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
    }
}
