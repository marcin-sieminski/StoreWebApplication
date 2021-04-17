﻿using System.Collections.Generic;

namespace StoreWebApplication.Mvc.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}
