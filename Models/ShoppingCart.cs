using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public double Sum { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Paid { get; set; }
        public virtual ICollection<Book> Items { get; set; }

        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            Sum = 0;
            DateCreated = DateTime.Now;
            Paid = false;
            Items = new List<Book>();
        }

        public void AddToCart(Book book)
        {
            Items.Add(book);
            Sum += book.Price;
        }

    }
}