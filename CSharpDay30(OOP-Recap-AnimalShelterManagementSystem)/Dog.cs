using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay30_OOP_Recap_AnimalShelterManagementSystem_
{
    internal class Dog : Animal, IFeedable, ITrainable
    {
        public string Breed { get; private set; }

        public Dog (string name, int age, string breed)
            : base (name, age)
        {
            Breed = breed;
        }

        public void Feed()
        {
            Console.WriteLine($"Feed by Dog Food!");

        }

        public void Train()
        {
            Console.WriteLine("Trainable Yes!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}
