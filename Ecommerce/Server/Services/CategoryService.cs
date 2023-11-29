
using Ecommerce.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _dataContext.Categories.ToListAsync();
            var response = new ServiceResponse<List<Category>>
            {
                Data = categories
            };

            return response;
        }
    }
}
