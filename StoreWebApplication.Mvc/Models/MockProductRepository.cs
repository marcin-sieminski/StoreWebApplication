using System.Collections.Generic;
using System.Linq;

namespace StoreWebApplication.Mvc.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts => new List<Product>
        {
            new()
            {
                ProductId = 1,
                Category = _categoryRepository.AllCategories.ToList()[0],
                ProductName = "Lorem ipsum 1", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 9.56M,
                OnStock = true
            },
            new()
            {
                ProductId = 2,
                Category = _categoryRepository.AllCategories.ToList()[2],
                ProductName = "Lorem ipsum 2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 59.99M,
                OnStock = true
            }
        };

        public Product GetProductById(int bookId)
        {
            return AllProducts.FirstOrDefault(product => product.ProductId == bookId);
        }
    }
}
