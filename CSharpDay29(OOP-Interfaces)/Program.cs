namespace CSharpDay29_OOP_Interfaces_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> printQueue = new List<IPrintable> { new Receipt(), new MultiFunctionPrinter() };

            foreach (var item in printQueue)
            {
                item.Print();
            }

            List<IScannable> scanQueue = new List<IScannable> { new Photo(), new MultiFunctionPrinter() };

            foreach (var item in scanQueue)
            {
                item.Scan();
            }
        }
    }
}
