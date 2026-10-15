using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay26_OOP_Recap_VanRentalSystem_
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; private set; }

        public Motorcycle (string plateNumber, string brand, decimal rentalPricePerDay, bool hasSideCar)
            :base(plateNumber, brand, rentalPricePerDay)
        {
            HasSideCar = hasSideCar;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"With Sidecar: {HasSideCar}");
        }

    }
}
