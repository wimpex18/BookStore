using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BookStore.DatabaseContext
{
	public class BookStoreDatabaseInitializer : DropCreateDatabaseIfModelChanges<BookShopDbContext>
	{
		protected override void Seed(BookShopDbContext context)
		{
			context.Books.AddOrUpdate(
				x => x.Name,
					new Book
					{
						Name = "Norwegian Wood",
						Author = "Haruko Murakami",
						Description = "The novel is a nostalgic story of loss and burgeoning sexuality",
						Year = 1987,
						Price = 15.95
					},
					new Book
					{
						Name = "Colorless Tsukuru Tazaki",
						Author = "Haruko Murakami",
						Description = "In this Bildungsroman of the realist kind (hints of the author's magical realism are left to dreams and tales)" +
									"the third-person narrative follows the past and present of Tsukuru Tazaki, a man who wants to understand why his life was derailed sixteen years ago..",
						Year = 2013,
						Price = 9.95
					},
					new Book
					{
						Name = "Before I Fall",
						Author = "Lauren Oliver",
						Description = "It is written in first-person narrative of a teenager who is forced to relive the day of her death every day for a week. ",
						Year = 2010,
						Price = 13.45
					},
					new Book
					{
						Name = "Delirium ",
						Author = "Lauren Oliver",
						Description = " a dystopian young adult novel written by Lauren Oliver, published on January 1, 2011, by HarperCollins (HarperTeen)," +
									  "about a young girl, Lena Haloway, who falls in love in a society where love is seen as a disease. ",
						Year = 2011,
						Price = 16.95
					},

					new Book
					{
						Name = "The Witcher ",
						Author = "Andrzej Sapkowski",
						Description = "The book revolves around the eponymous 'witcher', Geralt of Rivia. In Sapkowski's works, 'witcher'" +
										"are beast hunters who develop supernatural abilities at a young age to battle wild beasts and monsters.",
						Year = 1990,
						Price = 29.95
					}
				);
		}
	}
}