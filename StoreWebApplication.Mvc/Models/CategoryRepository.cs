using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public CategoryRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public IEnumerable<Category> AllCategories => _storeDbContext.Categories;
    }
}
