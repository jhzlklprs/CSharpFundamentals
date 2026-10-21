using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay30_OOP_Recap_AnimalShelterManagementSystem_
{
    internal class Cat : Animal, IFeedable
    {
        public bool IsIndoor { get; set; }

        public Cat (string name, int age, bool isIndoor)
            : base (name, age)
        {
            IsIndoor = isIndoor;
        }

        public void Feed()
        {
            Console.WriteLine("Feed by Cat Food");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwwww!");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Indoor: {IsIndoor}");
        }

    }
}
