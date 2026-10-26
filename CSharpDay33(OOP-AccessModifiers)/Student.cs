using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay33_OOP_AccessModifiers_
{
    internal class Student
    {
        public string StudentId { get; set; }
        private double _gpa;
        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("GPA can't be negative");
                }
                else
                {
                    _gpa = value;
                }
            }
        }

        protected string DisciplinaryNotes { get; set; }

        public Student (string studentId, double gPA, string disciplinaryNotes)
        {
            StudentId = studentId;
            GPA = gPA;
            DisciplinaryNotes = disciplinaryNotes;
        }

        public virtual void ShowBasicInfo()
        {
            Console.WriteLine($"StudentId: {StudentId}");
            Console.WriteLine($"GPA: {GPA}");
        }


    }
}
