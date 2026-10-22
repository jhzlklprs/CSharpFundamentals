using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay31_OOP_Composition_
{
    internal class CPU
    {
        public string Model { get; set; }
        public int Cores { get; set; }

        public CPU (string model, int cores)
        {
            Model = model;
            Cores = cores;
        }

        public void ShowSpecs()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Cores: {Cores}");
        }
    }
}
