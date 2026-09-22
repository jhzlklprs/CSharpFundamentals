namespace CSharpDay21_OOP_Properties_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Mission: Rebuild Book using properties instead of plain public fields.
            Book myBook = new Book();
            myBook.Title = "How to train your dragon";
            myBook.Author = "John Doe";
            myBook.Pages = -50;

            myBook.Checkout();
            myBook.DisplayInfo();
            
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

        }

    }
}
