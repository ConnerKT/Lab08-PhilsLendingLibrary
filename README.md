# Lab08-PhilsLendingLibrary# Phil's Lending Library

## Summary

Phil's Lending Library is a console-based application that allows users to manage a collection of books in a library and borrow them into their backpack. The application is built using Test-Driven Development (TDD) and includes classes for Book, Library, and a generic Backpack to hold borrowed items.

## Visuals



## How to Use

1. **Load Books:** When the application starts, it will automatically load some initial books into the library.

2. **View all Books:** This option allows the user to see a list of all the books available in the library. The details of each book, such as title, author, and number of pages, will be displayed.

3. **Add a Book:** Users can add a new book to the library by providing the title, author's first name, last name, and the number of pages.

4. **Borrow a Book:** Users can borrow a book from the library by providing the title of the book they want to borrow. If the book is available, it will be added to their backpack.

5. **Return a Book:** Users can return a book they borrowed by selecting the book from their backpack using its index (or number).

6. **View Book Bag:** This option displays a numbered list of books currently in the user's backpack.

7. **Exit:** This option allows the user to exit the application.

## How to Run

1. Clone the repository and navigate to the project directory.
2. Build the project using the provided build tool or your preferred IDE.
3. Run the application.
4. Follow the on-screen instructions to interact with the library and backpack.

## Additional Details

- The Library class implements the ILibrary interface, which includes methods to add, borrow, return, and search for books in the library.
- The Backpack class implements the IBag<T> interface, allowing it to hold any type of items, including books in this case.
- The DSA LinkedList has been updated to implement IEnumerable<int> and made generic to support any data type.
- The application has been developed using Test-Driven Development (TDD) to ensure robustness and reliability.

