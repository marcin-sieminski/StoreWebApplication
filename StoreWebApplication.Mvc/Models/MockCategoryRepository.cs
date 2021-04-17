using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new() {CategoryId = 1, CategoryName = "Category1"},
                new() {CategoryId = 2, CategoryName = "Category2"},
                new() {CategoryId = 3, CategoryName = "Category3"}
            };
    }
}
