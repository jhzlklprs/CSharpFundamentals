using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay31_OOP_Composition_
{
    internal class Computer
    {
        private CPU _cpu;
        private RAM _ram;
        private Storage _storage;

        public Computer (CPU cpu, RAM ram, Storage storage)
        {
            _cpu = cpu;
            _ram = ram;
            _storage = storage;
        }

        public void ShowFullSpecs()
        {
            Console.WriteLine("=== Computer Specs ===");
            _cpu.ShowSpecs();
            _ram.ShowSpecs();
            _storage.ShowSpecs();
        }
    }
}
