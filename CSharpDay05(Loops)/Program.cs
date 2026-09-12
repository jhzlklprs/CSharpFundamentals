//Day 05 - Loops

//TIPS

// 💡 How to practice effectively
// Don't peek at answers first — struggle a bit, it's how it sticks.
// Predict the output before running the code — then check if you were right.
// Break something on purpose — change < to <=, remove i++, see what happens (infinite loops are a great teacher).
// Rewrite one loop type as another — e.g. convert a for loop into a while loop that does the same thing. This forces you to really understand what each part does.

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


#region -- FOR LOOP EXERCISES --

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
// int sum = 0;

// for(int i = 1; i <= 100; i++)
// {
//     sum += i;

// }
//     Console.WriteLine(sum);

// Multiplication table — ask user for a number, print its table from 1x to 12x

// Console.WriteLine("Enter a number: ");
// int input = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 12; i++)
// {
//     int result = i * input;
//     Console.WriteLine(result);
// }


// Print a triangle pattern using *:
//    *
//    **
//    ***
//    ****
//    *****
// Factorial calculator — ask user for a number, calculate n! (e.g. 5! = 120)



#endregion

#region -- FOREACH EXERCISES --
// 🟢 foreach loop exercises


// Print every name in a List<string> of friends
// Sum all numbers in an int[] array
// Find the largest number in an array (track a "max" variable as you loop)
// Count vowels in a string — loop through each char in the string using foreach
// Print each key and value in a Dictionary<string, int> (e.g. student names + grades)
// Filter and print only strings longer than 5 characters from a List<string>


#endregion

#region -- WHILE LOOP EXERCISES --

// 🟡 while loop exercises
// Countdown from a user-given number to 0 using while
// Sum numbers until user types 0 — keep adding numbers the user enters; stop when they enter 0
// Simple guessing game — computer picks a number, user guesses; loop while the guess is wrong
// ATM-style balance loop — keep withdrawing money while balance > 0
// Reverse a number — e.g. input 1234, output 4321 (use % and / inside a while)

#endregion

#region -- DO WHILE LOOP EXERCISES --

// 🟠 do-while loop exercises
// Simple menu system:
//    1. Say Hello
//    2. Show Date
//    3. Exit

// Keep showing the menu (do-while) until user selects "Exit"

// Password retry system — ask for password do-while it's wrong (max 3 tries)
// "Play again?" game loop — after each round, ask (y/n), loop do-while answer is "y"
// Input validation — force user to enter a number between 1–10, do-while it's out of range

#endregion

#region -- Combined / mixed challenges (the real test!) --

// Once each loop feels natural on its own, these force you to choose the right loop for each part:

// 1. Number Guessing Game
// Computer picks random number 1–100
// do-while → loop the guessing (must guess at least once)
// Inside, use TryParse to validate input safely
// After winning, ask "Play again?" → outer do-while
// 2. Simple Inventory System
// List<string> of items with a foreach to display them
// for loop to number each item (1. Apple, 2. Bread, etc.)
// while loop for a menu: "Add item / Remove item / Exit" until user exits
// 3. Grade Calculator
// for loop to ask for grades for a fixed number of subjects (user says how many)
// foreach loop to calculate the average from the list you built
// if/else to print Pass/Fail based on average
// 4. FizzBuzz (classic!)
// Print numbers 1 to 100.
// If divisible by 3 → print "Fizz"
// If divisible by 5 → print "Buzz"
// If divisible by both → print "FizzBuzz"
// Otherwise → print the number

// This is a for loop + if/else exercise, and it's a famous interview question — worth doing.

#endregion


































