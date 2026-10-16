using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay27_OOP_Polymorphism_
{
    internal class PartTimeEmployee : Employee
    {
        private decimal hoursWorked;
        public decimal HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hours can't be negative!");
                }
                else
                {
                    hoursWorked = value;
                }
            }
        }

        private decimal hourlyRate;
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hourly rate can't be negative!");
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        public PartTimeEmployee(string name, string employeeId, decimal baseSalary, decimal hoursWorked, decimal hourlyRate)
            : base(name, employeeId, baseSalary)
        {
            BaseSalary = 0;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override decimal CalculatePay()
        {
            return HoursWorked * HourlyRate;
        }

        public override void ShowPayslip()
        {
            base.ShowPayslip();
            Console.WriteLine($"Hours Worked: {HoursWorked}");
            Console.WriteLine($"Hourly Rate: {HourlyRate}");
        }
    }
}
