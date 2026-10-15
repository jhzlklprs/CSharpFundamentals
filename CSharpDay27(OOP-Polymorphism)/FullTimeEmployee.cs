using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay27_OOP_Polymorphism_
{
    internal class FullTimeEmployee : Employee
    {
        private decimal monthlyBonus;
        public decimal MonthlyBonus
        {
            get { return monthlyBonus; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Monthly Bonus can't be negative!");
                }
                else
                {
                    monthlyBonus = value;
                }
            }
        }

        public FullTimeEmployee (string name, string employeeId, decimal baseSalary, decimal monthlyBonus)
            : base (name, employeeId, baseSalary)
        {
            MonthlyBonus = monthlyBonus;
        }

        public override decimal CalculatePay()
        {
            return base.CalculatePay() + MonthlyBonus;

        }

        public override void ShowPayslip()
        {
            base.ShowPayslip();
            Console.WriteLine($"Monthly Bonus: {MonthlyBonus}");
        }

    }
}
