using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay29_OOP_Interfaces_
{
    internal class Photo : IScannable
    {
        public void Scan()
        {
            Console.WriteLine("Scanning Photo...");
        }
    }
}
