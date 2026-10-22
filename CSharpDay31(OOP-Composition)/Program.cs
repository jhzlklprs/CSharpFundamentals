
namespace CSharpDay31_OOP_Composition_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPU cpu = new CPU("Intel", 7);
            RAM ram = new RAM(16, "DDR4");
            Storage storage = new Storage(512, "SSD");

            Computer computer = new Computer(cpu, ram, storage);

            computer.ShowFullSpecs();
        }
    }
}
