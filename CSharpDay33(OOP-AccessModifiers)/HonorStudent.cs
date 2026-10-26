using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay33_OOP_AccessModifiers_
{
    internal class HonorStudent : Student
    {

        public string Honors { get; set; }


        public HonorStudent(string studentId, double gPA, string disciplinaryNotes, string honors)
            : base(studentId, gPA, disciplinaryNotes)
        {
            Honors = honors;
        }

        public void ShowDisciplinaryStatus()
        {
            Console.WriteLine($"Disciplinary Notes: {DisciplinaryNotes}");
        }
    }
}
