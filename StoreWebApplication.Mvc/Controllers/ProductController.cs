using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreWebApplication.Mvc.Models;
using StoreWebApplication.Mvc.ViewModels;
using System.Diagnostics;

namespace StoreWebApplication.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var productListViewModel = new ProductListViewModel {Products = _productRepository.AllProducts};
            return View(productListViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
