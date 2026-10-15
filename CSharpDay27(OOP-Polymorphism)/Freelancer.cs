using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay27_OOP_Polymorphism_
{
    internal class Freelancer : Employee
    {
        private decimal projectRate;
        public decimal ProjectRate
        {
            get { return projectRate; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Project rate can't be negative!");
                }
                else
                {
                    projectRate = value;
                }
            }
        }

        private int numberOfProjects;
        public int NumberOfProjects
        {
            get { return numberOfProjects; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Number of projects can't be negative!");
                }
                else
                {
                    numberOfProjects = value;
                }
            }
        }

        public Freelancer(string name, string employeeId, decimal baseSalary, decimal projectRate, int numberOfProjects)
            : base(name, employeeId, baseSalary)
        {
            ProjectRate = projectRate;
            NumberOfProjects = numberOfProjects;
        }

        public override decimal CalculatePay()
        {
            return ProjectRate * NumberOfProjects;
        }

        public override void ShowPayslip()
        {
            base.ShowPayslip();
            Console.WriteLine($"Project Rate: {ProjectRate}");
            Console.WriteLine($"Number of projects: {NumberOfProjects}");
        }

    }
}
