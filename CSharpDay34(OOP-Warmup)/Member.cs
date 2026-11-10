using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay34_OOP_Warmup_
{
    internal abstract class Member
    {
        public string Name { get; protected set; }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age can't be negative!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        protected decimal BaseFee { get; set; }

        public static int TotalMembers;


        public Member(string name, int age)
        {
            Name = name;
            Age = age;
            TotalMembers++;

        }

        public abstract decimal CalculateMonthlyFee();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Monthly Fee: {CalculateMonthlyFee()}");
        }


    }
}
