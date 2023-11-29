
using Ecommerce.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _dataContext.Products.FindAsync(productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Product was not found";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductListAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dataContext.Products.ToListAsync()
            };

            return response;
        }
    }
}
