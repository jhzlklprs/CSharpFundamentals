using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay30_OOP_Recap_AnimalShelterManagementSystem_
{
    internal class Bird : Animal, IFeedable, ITrainable
    {
        public bool CanFly { get; set; }

        public Bird(string name, int age, bool canFly)
            : base(name, age)
        {
            CanFly = canFly;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Tweeet!");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Can Fly {CanFly}");
        }

        public void Feed()
        {
            Console.WriteLine($"Feed by seeds!");

        }

        public void Train()
        {
            Console.WriteLine("Trainable Yes!\n");
        }


    }
}
