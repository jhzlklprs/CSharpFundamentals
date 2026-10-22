using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay31_OOP_Composition_
{
    internal class Storage
    {
        public int Capacity { get; set; }
        public string StorageType { get; set; }

        public Storage (int capacity, string storageType)
        {
            Capacity = capacity;
            StorageType = storageType;
        }

        public void ShowSpecs()
        {
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Storage Type: {StorageType}");
        }
    }
}
