using System;
using System.Collections;

namespace Lab08_Phil_s_Lending_Library
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> Storage;

        public int Count { get; set; }

        public Library()
        {
            Storage = new Dictionary<string, Book>();
            //void Add(string title, string firstName,
            //string lastName, int numberOfPages);
            Book Book1 = new Book("To Killer a MockingBird", "Harper Lee", 100);
            Book Book2 = new Book("Americana", "Shemamonda", 100);
            Book Book3 = new Book("Berserk", "Kentaro Miura", 100);

            Storage.Add(Book1.Title, Book1);
            Storage.Add(Book2.Title, Book2);
            Storage.Add(Book3.Title, Book3);

        }
        //Add a book when the book is given a
        //title, first name, last, and page num.
        public void Add(string title, string author, int numberOfPages)
        {
            Book book = new Book(title, author, numberOfPages);
            Storage.Add(title, book);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return Storage.Values.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Book Borrow(string title)
        {
            Book returnedBook = Storage.GetValueOrDefault(title);
            Storage.Remove(returnedBook.Title);
            return returnedBook;

        }
        public void Return(Book book)
        {
            Storage.Add(book.Title, book);
        }
        public Book Search(string title)
        {
            bool result = Storage.ContainsKey(title);
            if (result == true)
            {
                return Storage[title];
            }
            return null;
        }
        public void ViewAllBooks()
        {
            var keys = Storage.Keys;
            for (int i = 0; i < keys.Count; i++)
            {
                
                string key = keys.ElementAt(i);
                Console.WriteLine(key + " ");
                

            }
        }

        
    }
}

