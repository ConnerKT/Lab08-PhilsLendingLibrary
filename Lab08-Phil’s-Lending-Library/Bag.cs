using System;
using System.Collections;

namespace Lab08_Phil_s_Lending_Library
{
    public class Backpack : IBag<Book>
    {
        private List<Book> Storage;

        public Backpack()
        {
            Storage = new List<Book>();
        }
        public void Pack(Book item)
        {
            Storage.Add(item);
        }

        public Book Unpack(int index)
        {


            for (int i = 0; i < Storage.Count; i++)
            {
                Book currentBook = Storage[i];
                if (index == i)
                {
                    return currentBook;
                }
            }
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<Book> GetEnumerator()
        {

            foreach (Book book in Storage)
            {
                yield return book;
            }
        }
        public void ViewAll()
        {
            for (int i = 0; i < Storage.Count; i++)
            {
                string bookTitle = Storage[i].Title;
                Console.WriteLine($"[{i}] {bookTitle}");
            }
        }

    }
}


