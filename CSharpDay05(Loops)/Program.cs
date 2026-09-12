//Day 05 - Loops

#region -- LOOPS --

#region --Exercise 1--
//for (int i = 1; i <= 3; i++)
//{
//    Console.WriteLine("C#");
//}
#endregion

#region --Exercise 2--
//for (int i = 5; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}
#endregion

#region --Exercise 3--

//int x = 3;

//while (x > 0)
//{
//    Console.WriteLine(x);
//    x--;
//}

#endregion

#region --DoWhileLoop--

//int number = 10;

//do
//{
//    Console.WriteLine(number);
//}
//while (number < 5);

#endregion

#region --ForEachLoop--

//string[] fruits = { "Apple", "Banna", "Orange" };

//foreach (string fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}

#endregion

#region --Mini Challenge 1--

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

#endregion

#region --Mini Challenge 2--

//for (int i = 2; i <= 10; i+= 2)
//{
//    Console.WriteLine(i);
//}

#endregion

#region --Mini Challenge 3--

//for (int i = 5; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}

#endregion

#region --Question 1--

//for (int i = 2; i <= 8; i += 2)
//{
//    Console.WriteLine(i);
//}

#endregion

#region --Question 2--

//int x = 1;

//while (x < 4)
//{
//    Console.WriteLine(x);
//    x++;
//}
#endregion

#region --Question 3--

//for (int i = 5; i > 0; i--)
//{
//    if (i == 3)
//    {
//        continue;
//    }

//    Console.WriteLine(i);
//}
#endregion

#region --Mini Challenge 1*--
//Print 1 through 10

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

#endregion

#region --Mini Challenge 2*--
//Print even numbers 2, 4, 6, 8, 10

//for (int i = 2; i <=10; i+=2)
//{
//    Console.WriteLine(i);
//}

#endregion

#region --Mini Challenge 3*--
//Use a while loop to print 5 down to 1

// while (true)
// {
//    int x = 5;
//    while (x > 0)
//    {
//        Console.WriteLine(x);
//        x--;
//    }
//    break;
// }

#endregion

#region -- for loop — Printing a multiplication table --

// Console.WriteLine("Enter a number for its multiplication table:");
// int num = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{num} x {i} = {num * i}");
// }

#endregion

#region -- while loop — ATM balance checker --

// double balance = 5000;

// while (balance > 0)
// {
//     Console.WriteLine($"Current balance: {balance}");
//     Console.WriteLine("Enter withdrawal amount: (or 0 to exit)");
//     double withdraw = double.Parse(Console.ReadLine());

//     if (withdraw == 0) break;

//     if (withdraw > balance)
//         Console.WriteLine("Insufficient funds.");
//     else
//         balance -= withdraw;
        
// }

// Console.WriteLine("Session ended.");


#endregion

#region -- do-while loop — Simple login retry system --

// string password;
// int attempts = 0;

// do
// {
//     Console.WriteLine("Enter your password: ");
//     password = Console.ReadLine();

//     if (password != "1234")
//     {
//         Console.WriteLine("Incorrect password. Try again.");
//         attempts++;
//     }

    
// }while (password != "1234" && attempts < 3);

// if (password == "1234")
// {
//     Console.WriteLine("Access Granted.");
// }
// else
// {
//     Console.WriteLine("Account locked. Too many attempts.");
// }


#endregion


#endregion


#region -- PRACTICE FOR --

// 🔵 for loop exercises
// Print numbers 1 to 20
// for (int i = 1; i < 21; i++)
// {
//     Console.WriteLine(i);
// }

// Print only even numbers from 1 to 50
// for (int i = 2; i < 51; i+=2)
// {
//     Console.WriteLine(i);
// }

// Print a countdown from 10 to 1, then print "Liftoff!"
//     for (int i = 10; i > 0; i--)
// {
//     Console.WriteLine(i);

// }
//     Console.WriteLine("Liftoff!");

// Sum of numbers 1 to 100 (add them all up, print the total)



// Multiplication table — ask user for a number, print its table from 1x to 12x

// Print a triangle pattern using *:
//    *
//    **
//    ***
//    ****
//    *****
// Factorial calculator — ask user for a number, calculate n! (e.g. 5! = 120)



#endregion














































