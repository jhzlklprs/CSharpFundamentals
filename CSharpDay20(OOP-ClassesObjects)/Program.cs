using System;
using System.Reflection;
using System.Security.Principal;

namespace CSharpDay20_OOP_ClassesObjects_
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Quick exercise
    //        //Mission: Model a Book that a small library app could use.

    //        Book myBook = new Book();
    //        myBook.Title = "How to Train your Dragon";
    //        myBook.Author = "John Doe";
    //        myBook.Pages = 265;

    //        Book secondBook = new Book();
    //        secondBook.Title = "Prince of Persia";
    //        secondBook.Author = "Sarah Doe";
    //        secondBook.Pages = 300;

    //        myBook.Checkout();      // only myBook gets checked out
    //        myBook.DisplayInfo();
    //        secondBook.DisplayInfo(); // secondBook was never touched

    //    }

    //    class Book
    //    {
    //        public string Title;
    //        public string Author;
    //        public int Pages;
    //        public bool IsCheckedOut;

    //        public void DisplayInfo()
    //        {
    //            Console.WriteLine($"Title: {Title}");
    //            Console.WriteLine($"Author: {Author}");
    //            Console.WriteLine($"Pages: {Pages}");
    //            Console.WriteLine($"Checked Out: {IsCheckedOut}\n");
    //        }

    //        public void Checkout()
    //        {
    //            if (IsCheckedOut)
    //            {
    //                Console.WriteLine($"{Title} is already checked out.");
    //            }
    //            else
    //            {
    //                IsCheckedOut = true;   // <- the actual action happens here
    //                Console.WriteLine($"{Title} has been checked out.");
    //            }
    //        }
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Quick exercise: BankAccount
    //        //Mission: Model a simple bank account that a small banking app could use.

    //        BankAccount myBank = new BankAccount();
    //        myBank.AccountHolder = "Kiel";
    //        myBank.AccountNumber = "12345XYZABC";
    //        myBank.Balance = 500;

    //        myBank.DisplayInfo();
    //        myBank.Deposit(500);
    //        myBank.Withdraw(300);

    //        BankAccount my2ndBank = new BankAccount();
    //        my2ndBank.AccountHolder = "Sarah";
    //        my2ndBank.AccountNumber = "12345XYZZXC";
    //        my2ndBank.Balance = 500;

    //        my2ndBank.DisplayInfo();
    //        my2ndBank.Deposit(500);
    //        my2ndBank.Withdraw(1200);


    //    }

    //    class BankAccount
    //    {
    //        public string AccountHolder;
    //        public string AccountNumber;
    //        public decimal Balance;

    //        public void DisplayInfo()
    //        {
    //            Console.WriteLine($"Account Holder: {AccountHolder}");
    //            Console.WriteLine($"Account Number: {AccountNumber}");
    //            Console.WriteLine($"Balance: {Balance}");
    //        }

    //        public void Deposit(decimal amount)
    //        {
    //            Balance = amount + Balance;
    //            Console.WriteLine($"Deposited: {amount}, new balance {Balance}");
    //        }

    //        public void Withdraw(decimal amount)
    //        {

    //            if (Balance < amount)
    //            {
    //                Console.WriteLine("Insufficient funds");
    //            }
    //            else
    //            {
    //                Balance = Balance - amount;
    //                Console.WriteLine($"Withdraw: {amount}, new balance {Balance}\n");
    //            }

    //        }
    //    }

    //}



    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Quick exercise: PersonalStaff
    //        Programmer prg = new Programmer();

    //        prg.Name = "Kiel";
    //        prg.Age = 29;
    //        prg.JobTitle = "System Prgrammer I";

    //        prg.DisplayInfo();


    //    }

    //    class Programmer
    //    {
    //        public string Name;
    //        public int Age;
    //        public string JobTitle;



    //        public void DisplayInfo()
    //        {
    //            Console.WriteLine($"Programmer: {Name}");
    //            Console.WriteLine($"Age: {Age}");
    //            Console.WriteLine($"Job Title: {JobTitle}");
    //        }
    //    }

    //}
}

