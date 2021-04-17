using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> AllBooks { get; }
        IEnumerable<Book> BooksOfTheWeek { get; }
        Book GetBookById(int bookId);
    }
}
