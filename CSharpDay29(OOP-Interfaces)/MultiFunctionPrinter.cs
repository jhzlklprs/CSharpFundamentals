using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay29_OOP_Interfaces_
{
    internal class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing via multi-function printer...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning via multi-function printer...");
        }
    }
}
