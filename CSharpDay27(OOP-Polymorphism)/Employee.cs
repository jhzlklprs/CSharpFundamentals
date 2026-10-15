using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay27_OOP_Polymorphism_
{
    internal class Employee
    {
        public string Name { get; protected set; }
        public string EmployeeId { get; protected set; }
        private decimal baseSalary;
        public decimal BaseSalary
        {
            get { return baseSalary; }
            protected set
            {
                if (value < 0)
                {
                    Console.WriteLine("Salary can't be negative!");
                }
                else
                {
                    baseSalary = value;
                }
            }
        }

        public Employee (string name, string employeeId, decimal baseSalary)
        {
            Name = name;
            EmployeeId = employeeId;
            BaseSalary = baseSalary;
        }

        public virtual decimal CalculatePay()
        {
            return BaseSalary;
        }

        public virtual void ShowPayslip()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Pay: {CalculatePay()}");
        }



    }
}
