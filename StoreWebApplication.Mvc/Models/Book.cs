using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public List<Author> Authors { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsBookOfTheWeek { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool OnStock { get; set; }
    }
}
