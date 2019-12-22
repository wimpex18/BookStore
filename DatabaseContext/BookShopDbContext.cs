using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BookStore.DatabaseContext
{
    public class BookShopDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}