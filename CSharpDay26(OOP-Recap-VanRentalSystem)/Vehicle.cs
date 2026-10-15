using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay26_OOP_Recap_VanRentalSystem_
{
    internal class Vehicle
    {
        public string PlateNumber { get; private set; }
        public string Brand { get; private set; }
        public decimal RentalPricePerDay { get; private set; }

        public bool IsRented { get; private set; }

        public Vehicle (string plateNumber, string brand, decimal rentalPricePerDay)
        {
            PlateNumber = plateNumber;
            Brand = brand;
            RentalPricePerDay = rentalPricePerDay;
        }

        public void Rent()
        {
            if (IsRented)
            {
                Console.WriteLine("Already Rented!");
            }
            else
            {
                IsRented = true;
                Console.WriteLine("Vehicle rented successfully!");
            }
            
        }

        public void Return()
        {
            if (!IsRented)
            {
                Console.WriteLine("Vehicle is not currently rented.");
                return;
            }

            IsRented = false;
            Console.WriteLine("Vehicle returned successfully!");
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Plate Number: {PlateNumber}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Rental Price Per Day: {RentalPricePerDay}");
            Console.WriteLine($"Status: {(IsRented ? "Rented" : "Available")}");
        }
    }
}
