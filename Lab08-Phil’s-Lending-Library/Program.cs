
using System;

namespace Lab08_Phil_s_Lending_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Backpack backPack = new Backpack();

            Console.WriteLine("Hello welcome to my Library");
            bool game = true;
            while (game)
            {
                Console.WriteLine("Press the corresponding key to continue.");
                Console.WriteLine("Add a Book [1]");
                Console.WriteLine("Borrow a Book [2]");
                Console.WriteLine("Return a Book [3]");
                Console.WriteLine("Search for a book [4]");
                Console.WriteLine("View All Books [5]");
                Console.WriteLine("Exit [6]");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter your title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter the author's name:");
                        string author = Console.ReadLine();

                        Console.Write("Enter the amount of pages: ");
                        int pages = Convert.ToInt32(Console.ReadLine());

                        library.Add(title, author, pages);
                        Thread.Sleep(100);
                        break;

                    case "2":
                        Console.WriteLine("Enter a title of a book to borrow: ");
                        string borrowtitle = Console.ReadLine();
                        Book borrowedBook = library.Borrow(borrowtitle);
                        backPack.Pack(borrowedBook);
                        Thread.Sleep(100);

                        break;

                    case "3":
                        backPack.ViewAll();
                        Console.WriteLine("Enter a title of a book to return: ");
                        int returnBook = Convert.ToInt32(Console.ReadLine());
                        Book returnedBook = backPack.Unpack(returnBook);
                        library.Return(returnedBook);
                        Console.WriteLine("Your book has been returned!");
                        library.ViewAllBooks();
                        Thread.Sleep(100);
                        break;

                    case "4":
                        Console.WriteLine("Enter a title of a book to search for: ");
                        string searchBook = Console.ReadLine();
                        Book searchedBook = library.Search(searchBook);
                        Console.WriteLine(searchedBook.Title + " is in the system!");
                        Thread.Sleep(100);
                        break;

                    case "5":// View All Books
                        
                        Console.WriteLine("################");
                        library.ViewAllBooks();
                        Console.WriteLine("################");
                        Thread.Sleep(100);
                        break;

                    case "6":
                        game = false;
                        break;

                }
            }
        }
    }
}