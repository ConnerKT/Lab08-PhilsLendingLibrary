using System;
namespace Lab08_Phil_s_Lending_Library
{
	public class Library : ILibrary
	{
		private Dictionary<string, Book> Storage;

		public Library()
		{
            //void Add(string title, string firstName,
			//string lastName, int numberOfPages);
            Book Book1 = new Book("To Killer a MockingBird", "Harper Lee", 100);
            Book Book2 = new Book("Americana", "Shemamonda", 100);
            Book Book3 = new Book("Berserk", "Kentaro Miura", 100);

			Storage.Add(Book1.Title, Book1);
            Storage.Add(Book2.Title, Book2);
            Storage.Add(Book3.Title, Book3);

        }
		
	}
}

