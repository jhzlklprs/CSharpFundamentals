using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay24_OOP_Recap_LibrarySystem_
{
    internal class Library
    {
        private List<Book> catalog = new List<Book>();

        public void AddBook(Book book)
        {
            catalog.Add(book);
        }

        public void BorrowBook(Member member, string isbn)
        {
            Book foundBook = null;
            foreach (var book in catalog)
            {
                if (book.ISBN == isbn)
                {
                    foundBook = book;
                    break;
                }
            }

            if (foundBook == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (foundBook.IsBorrowed)
            {
                Console.WriteLine("Book is already borrowed.");
            }
            else
            {
                foundBook.MarkBorrowed();
                member.AddBorrowedBook(foundBook);
                Console.WriteLine($"{member.Name} borrowed {foundBook.Title}.");
            }
        }

        public void ReturnBook(Member member, string isbn)
        {
            Book foundReturnBook = null;
            foreach (var book in catalog)
            {
                if (book.ISBN == isbn)
                {
                    foundReturnBook = book;
                    break;
                }
            }

            if (foundReturnBook == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (!foundReturnBook.IsBorrowed)
            {
                Console.WriteLine("Book is not currently borrowed.");
            }
            else
            {
                foundReturnBook.MarkReturned();
                member.RemoveBorrowedBook(foundReturnBook);
                Console.WriteLine($"{member.Name} returned {foundReturnBook.Title}.");
            }
        }
    }
}
