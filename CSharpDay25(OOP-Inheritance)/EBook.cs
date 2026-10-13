using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay25_OOP_Inheritance_
{
    internal class EBook : Book
    {

            public double FileSizeMB { get; set; }
            public string Format { get; set; }

            public EBook(string title, string author, string isbn, string format, double fileSizeMB)
                : base(title, author, isbn)
            {
                Format = format;
                FileSizeMB = fileSizeMB;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Format: {Format}, Size: {FileSizeMB}MB");
            }
        
    }
}
