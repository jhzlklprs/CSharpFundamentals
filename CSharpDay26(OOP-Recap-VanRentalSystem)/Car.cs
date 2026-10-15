using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay26_OOP_Recap_VanRentalSystem_
{
    internal class Car : Vehicle
    {
        private int numberOfSeats;
        public int NumberOfSeats
        {
            get { return numberOfSeats;  }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value), "A car must have at least one seat.");
                }
                else
                {
                    numberOfSeats = value;
                }
            }
        }

        public Car (string plateNumber, string brand, decimal rentalPricePerDay, int numberOfSeats)
            :base(plateNumber, brand, rentalPricePerDay)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Number of Seats: {numberOfSeats}");
        }
    }
}
