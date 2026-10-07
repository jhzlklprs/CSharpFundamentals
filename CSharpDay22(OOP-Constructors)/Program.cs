namespace CSharpDay22_OOP_Constructors_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("How to Train your Dragon", "John Doe", 265);
            myBook.Checkout();
            myBook.DisplayInfo();

            Book testBook = new Book("Test", "Test", -10);
            testBook.DisplayInfo();
        }


        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public bool IsCheckedOut { get; private set; }
            

            private int pages;
            public int Pages
            {
                get { return pages; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Pages can't be negative.");
                    }
                    else
                    {
                        pages = value;
                    }
                }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Pages: {Pages}");
                Console.WriteLine($"Checked Out: {IsCheckedOut}\n");
            }


            public void Checkout()
            {
                if (IsCheckedOut)
                {
                    Console.WriteLine($"{Title} is already checked out.");
                }
                else
                {
                    IsCheckedOut = true;
                    Console.WriteLine($"{Title} has been checked out.");
                }
            }

            public Book(string title, string author, int pages)
            {
                Title = title;
                Author = author;
                Pages = pages;
            }

        }
    }
}
