using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        Product GetProductById(int bookId);
    }
}
