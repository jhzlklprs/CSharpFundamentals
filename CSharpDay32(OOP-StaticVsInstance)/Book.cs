using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay32_OOP_StaticVsInstance_
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public static int TotalBooksInLibray;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            TotalBooksInLibray++;
        }

        public void ShowInfo()
        {

            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}\n");
        }
    }
}
