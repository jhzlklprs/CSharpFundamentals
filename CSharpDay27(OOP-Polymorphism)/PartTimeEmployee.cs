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
                    HourlyRate = value;
                }
            }
        }

        public PartTimeEmployee(string name, string employeeId, decimal baseSalary)
            : base(name, employeeId, baseSalary)
        {
            baseSalary = 0;
        }

        public override decimal CalculatePay()
        {
            return HoursWorked * HourlyRate;
        }

        public override void ShowPayslip()
        {
            base.ShowPayslip();
        }
    }
}
