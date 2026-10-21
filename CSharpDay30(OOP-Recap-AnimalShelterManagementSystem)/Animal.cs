using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay30_OOP_Recap_AnimalShelterManagementSystem_
{
    internal abstract class Animal
    {
        public string Name { get; private set; }

        private int _age;
        public int Age
        {
            get { return _age;  }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age can't be negative number!");
                }
                else
                {
                   _age = value;
                }
            }
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }

    }
}
