using System.ComponentModel;

namespace CSharpDay26_OOP_Recap_VanRentalSystem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Car myCar = new Car("123XYZ", "Toyota", 1200, 4);
            Motorcycle myMotorcycle = new Motorcycle("ABCXYZ", "Yamaha", 1200, false);

            vehicles.Add(myCar);
            vehicles.Add(myMotorcycle);

            foreach (var v in vehicles)
            {
                v.ShowDetails();
            }

            Console.WriteLine();

            myCar.Rent();     // dapat: "Vehicle rented successfully!"
            myCar.Rent();     // dapat: "Already Rented!" (second try, rented na)
            myCar.Return();   // dapat: "Vehicle returned successfully!"
            myCar.Return();   // dapat: "Vehicle is not currently rented." (second try, wala nang rented)
        }
    }
}
