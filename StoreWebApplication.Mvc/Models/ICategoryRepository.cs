using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
