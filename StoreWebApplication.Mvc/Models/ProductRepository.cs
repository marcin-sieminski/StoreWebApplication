using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace StoreWebApplication.Mvc.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public ProductRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _storeDbContext.Products.Include(c => c.Category);
            }
        }

        public Product GetProductById(int productId)
        {
            return _storeDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
