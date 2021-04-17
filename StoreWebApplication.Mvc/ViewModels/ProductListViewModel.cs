using StoreWebApplication.Mvc.Models;
using System.Collections.Generic;

namespace StoreWebApplication.Mvc.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
