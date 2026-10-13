using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay24_OOP_Recap_LibrarySystem_
{
    internal class Member
    {
        public string Name { get; set; }
        public string MemberId { get; set; }

        private List<Book> borrowedBooks = new List<Book>();
        public int BorrowedCount => borrowedBooks.Count;

        public Member (string name, string memberId)
        {
            Name = name;
            MemberId = memberId;
        }

        public void AddBorrowedBook(Book book)
        {
            borrowedBooks.Add(book);
            Console.WriteLine($"Borrowed Books: {borrowedBooks.Count}");
        }

        public void RemoveBorrowedBook(Book book)
        {
            borrowedBooks.Remove(book);
            Console.WriteLine($"Borrowed Books: {borrowedBooks.Count}");
        }
    }
}
