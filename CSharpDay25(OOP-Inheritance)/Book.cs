using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay25_OOP_Inheritance_
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        private bool isBorrowed;
        public bool IsBorrowed
        {
            get { return isBorrowed; }
        }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            isBorrowed = false;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Status: {IsBorrowed}");
        }

        public void MarkBorrowed()
        {
            isBorrowed = true;
        }

        public void MarkReturned()
        {
            isBorrowed = false;
        }
    }

}
