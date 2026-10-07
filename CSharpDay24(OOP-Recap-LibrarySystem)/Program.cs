namespace CSharpDay24_OOP_Recap_LibrarySystem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook1 = new Book("Book1", "John Doe", "B1");
            Book myBook2 = new Book("Book2", "James Will", "B2");
            Book myBook3 = new Book("Book3", "Jane Smith", "B3");
            myBook1.DisplayInfo();


            Member member1 = new Member("Member1", "M1");
            member1.AddBorrowedBook(myBook1);

        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            private bool isBorrowed;
            public bool IsBorrowed
            {
                get { return isBorrowed; }
            }


            public void DisplayInfo()
            {
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"ISBN: {ISBN}");
                Console.WriteLine($"Status: {IsBorrowed}");
            }

            public void MarkBorrowed()
            {
                isBorrowed = true;
            }

            public void MarkReturned()
            {
                isBorrowed = false;
            }


            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                isBorrowed = false;
            }

        }

        class Member
        {
            public string Name { get; set; }
            public string MemberId { get; set; }
            private List<Book> borrowedBooks = new List<Book>();
            public int BorrowedCount => borrowedBooks.Count;


            public Member(string name, string memberId)
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



        class Library
        {
            private List<Book> catalog = new List<Book>();


            public Library()
            {
                
            }

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
        }


    }
}
