using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay31_OOP_Composition_
{
    internal class RAM
    {
        public int SizeInGB { get; set; }
        public string Type { get; set; }

        public RAM(int sizeInGB, string type)
        {
            SizeInGB = sizeInGB;
            Type = type;
        }

        public void ShowSpecs()
        {
            Console.WriteLine($"Size in GB: {SizeInGB}");
            Console.WriteLine($"Type: {Type}");
        }
    }
}
