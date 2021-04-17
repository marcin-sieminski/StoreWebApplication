using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> AllAuthors { get; }
        Author GetAuthorById(int authorId);
    }
}
