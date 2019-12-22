using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public Book()
        {
            Id = Guid.NewGuid();
        }
    }
}