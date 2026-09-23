using System.Windows.Markup;

namespace CSharpDay21_OOP_Properties_
{
    #region -- Rebuild Book --
    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        //Mission: Rebuild Book using properties instead of plain public fields.
    //        Book myBook = new Book();
    //        myBook.Title = "How to train your dragon";
    //        myBook.Author = "John Doe";
    //        myBook.Pages = -50;

    //        myBook.Checkout();
    //        myBook.DisplayInfo();

    //    }


    //    class Book
    //    {
    //        public string Title { get; set; }
    //        public string Author { get; set; }
    //        public bool IsCheckedOut { get; private set; }

    //        private int pages;
    //        public int Pages
    //        {
    //            get { return pages; }
    //            set
    //            {
    //                if (value < 0)
    //                {
    //                    Console.WriteLine("Pages can't be negative.");
    //                }
    //                else
    //                {
    //                    pages = value;
    //                }
    //            }
    //        }


    //        public void DisplayInfo()
    //        {
    //            Console.WriteLine($"Title: {Title}");
    //            Console.WriteLine($"Author: {Author}");
    //            Console.WriteLine($"Pages: {Pages}");
    //            Console.WriteLine($"Checked Out: {IsCheckedOut}\n");

    //        }



    //        public void Checkout()
    //        {
    //            if (IsCheckedOut)
    //            {
    //                Console.WriteLine($"{Title} is already checked out.");
    //            }
    //            else
    //            {
    //                IsCheckedOut = true;   
    //                Console.WriteLine($"{Title} has been checked out.");
    //            }
    //        }

    //    }

    //}
    #endregion

    #region --Employee--
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee myEmp = new Employee();

    //        myEmp.FirstName = "Jahzeel";
    //        myEmp.LastName = "Kiel";
    //        myEmp.Salary = 20000;
    //        myEmp.YearsOfService = -3;
    //        myEmp.YearsOfService = 6;

    //        myEmp.DisplayInfo();
    //        myEmp.ComputeYears();

    //    }

    //    class Employee
    //    {
    //        public string FirstName { get; set; }
    //        public string LastName { get; set; }

    //        private decimal salary;
    //        public decimal Salary
    //        {
    //            get { return salary; }
    //            set
    //            {
    //                if (value <= 0)
    //                {
    //                    Console.WriteLine("Salary can't be below or equal to 0.");
    //                }
    //                else
    //                {
    //                    salary = value;
    //                }
    //            }
    //        }

    //        private int years;
    //        public int YearsOfService
    //        {
    //            get { return years; }
    //            set
    //            {
    //                if (value < 0)
    //                {
    //                    Console.WriteLine("Years can't be negative.");
    //                }
    //                else
    //                {
    //                    years = value;
    //                }
    //            }
    //        }
    //        public bool IsSenior => YearsOfService >= 5;
    //        public void ComputeYears()
    //        {
    //            if (IsSenior)
    //            {
    //                Console.WriteLine("Employee is Senior!");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Employee is Junior");
    //            }

    //        }

    //        public void DisplayInfo()
    //        {
    //            Console.WriteLine($"Employee name: {FirstName} {LastName}");
    //            Console.WriteLine($"Salary: {Salary}");
    //        }

    //    }

    //}
    #endregion

    #region --Product--

    internal class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product();

            myProduct.Price = 2;
            myProduct.StockQuantity = 5;

            myProduct.Sell(3);
        }

        class Product
        {
            public string Name { get; set; }
            private decimal price;
            public decimal Price
            {
                get { return price; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Invalid price");
                    }
                    else
                    {
                        price = value;
                    }
                }
            }

            private int stockQuantity;
            public int StockQuantity
            {
                get { return stockQuantity; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Invalid! Please enter valid number!");
                    }
                    else
                    {
                        stockQuantity = value;
                    }
                }
            }

            public bool IsInStock => StockQuantity > 0;

            public decimal TotalValue => Price * StockQuantity;

            public void Sell(int quantity)
            {
                if (quantity == 0)
                {
                    Console.WriteLine("Invalid input, can't input 0.");
                }

                else if (quantity > StockQuantity)
                {
                    Console.WriteLine("There isn't enough stock");
                }
                else
                {
                    StockQuantity = StockQuantity - quantity;
                    Console.WriteLine($"Sold Successfully");
                    Console.WriteLine($"New Stock is: {StockQuantity}");
                }
            }

        }
    }


    #endregion
}
