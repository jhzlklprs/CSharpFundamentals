namespace CSharpDay32_OOP_StaticVsInstance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>();

            Book book1 = new Book("Book 1", "John Doe");
            Book book2 = new Book("Book 2", "Jane Smith");
            Book book3 = new Book("Book 3", "Eren Yeager");
            Book book4 = new Book("Book 4", "Mikasa Ackerman");
            Book book5 = new Book("Book 5", "Levi Doe");
            

            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);
            Books.Add(book4);
            Books.Add(book5);


            foreach (var b in Books)
            {
                b.ShowInfo();
            }

            Console.WriteLine($"Total Books: {Book.TotalBooksInLibray}");





        }
    }
}
