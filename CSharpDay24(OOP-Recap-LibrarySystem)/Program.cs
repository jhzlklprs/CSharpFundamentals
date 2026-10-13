namespace CSharpDay24_OOP_Recap_LibrarySystem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book myBook1 = new Book("Book1", "John Doe", "B1");
            Book myBook2 = new Book("Book2", "James Will", "B2");
            Book myBook3 = new Book("Book3", "Jane Smith", "B3");

            library.AddBook(myBook1);
            library.AddBook(myBook2);
            library.AddBook(myBook3);

            Member member1 = new Member("Member1", "M1");
            Member member2 = new Member("Member2", "M2");

            library.BorrowBook(member1, "B1");
            library.BorrowBook(member2, "B1");

            library.ReturnBook(member1, "B1");
            library.BorrowBook(member2, "B1");

            Console.WriteLine($"Member1 borrowed count: {member1.BorrowedCount}");
            Console.WriteLine($"Member2 borrowed count: {member2.BorrowedCount}");
        }

    }
}
