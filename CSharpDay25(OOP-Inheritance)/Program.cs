namespace CSharpDay25_OOP_Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Maze Runner", "John Doe", "abc");
            EBook myEbook = new EBook("Ready Player One", "Ernest Cline", "xyz", "EPUB", 3.4);

            myEbook.DisplayInfo();
        }

    }
}
