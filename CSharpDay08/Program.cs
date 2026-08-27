//C# Collections: Arrays

#region --Exercise 1 — Your Turn--
//Create an array containing these numbers: 10, 20, 30, 40, 50
//int[] numbers = { 10, 20, 30, 40, 50 };

//Console.WriteLine(numbers[2]);

#endregion

#region --Exercise 2 — Change an Element--
//Create string[] fruits = { "Apple", "Banana", "Orange" };

//string[] fruits = { "Apple", "Banna", "Orange" };

//fruits[1] = "Mango";

//Console.WriteLine(fruits[1]);

#endregion

#region --Exercise 3 — Length--
//Create:int[] scores = { 90, 85, 78, 95, 88 };
//Print how many elements are in the array.

//int[] scores = { 90, 85, 78, 95, 88 };

//Console.WriteLine(scores.Length);


#endregion

#region --Exercise 4 — foreach--
//Create: string[] names = { "Kiel", "John", "Mark", "Anna" };
//Use foreach to print every name.

//string[] names = { "Kiel", "John", "Mark", "Anna" };

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

#endregion

#region --🎯 Mini Challenge--
//Given: int[] numbers = { 5, 10, 15, 20, 25 };
//Use foreach to print only numbers greater than 10.

//int[] numbers = { 5, 10, 15, 20, 25 };

//foreach (int number in numbers)
//{
//    if (number > 10)
//    {
//        Console.WriteLine(number);
//    }
//}
#endregion

#region --Array Challenge 1--
//Use foreach to:
//Given: int[] numbers = { 12, 5, 8, 21, 30, 7, 15 };
//Print only the even numbers

//int[] numbers = { 12, 5, 8, 21, 30, 7, 15 };

//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//}
#endregion

#region --Array Challenge 2--
//Use foreach to:
//Print only numbers greater than 10

//int[] numbers = { 12, 5, 8, 21, 30, 7, 15 };

//foreach (int number in numbers)
//{
//    if(number > 10)
//    {
//        Console.WriteLine(number);
//    }
//}
#endregion

#region --Array Challenge 3--
//Use foreach to:
//Count how many numbers are greater than 10
//int count = 0; count++;

//int[] numbers = { 12, 5, 8, 21, 30, 7, 15 };

//int count = 0;
//foreach (int number in numbers)
//{
//    if (number > 10)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count);
#endregion


//🚀 C# Arrays — Practice Set

#region --Exercise 1 — Print All Elements--
//Given: int[] numbers = { 10, 20, 30, 40, 50 };
//Use foreach to print every number.

//int[] numbers = { 10, 20, 30, 40, 50 };

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}



#endregion


#region --Exercise 2 — Find the Largest Number--
//Given: int[] numbers = { 12, 45, 7, 89, 23 };
//Use foreach to find and print the largest number.

//int[] numbers = { 12, 45, 7, 89, 23 };

//int largest = numbers[0];

//foreach (int number in numbers)
//{
//    if (number > largest)
//    {
//        largest = number;
//    }
//}

//Console.WriteLine(largest);
#endregion


#region --Exercise 3 — Count Even Numbers--
//Given: int[] numbers = { 3, 8, 12, 7, 15, 20, 22 };
//Use foreach to count how many numbers are even.

//int[] numbers = { 3, 8, 12, 7, 15, 20, 22 };
//int count = 0;
//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion


#region --Exercise 4 — Calculate the Sum--
//Given: int[] numbers = { 5, 10, 15, 20, 25 };
//Use foreach to calculate the sum of all numbers.

//int[] numbers = { 5, 10, 15, 20, 25 };
//int sum = 0;

//foreach (int number in numbers)
//{
//    sum += number;
//}
//Console.WriteLine(sum);
#endregion


#region --Exercise 5 — Find the Average--
//Given: int[] scores = { 80, 90, 70, 100, 60 };
//Calculate and print the average.


//int[] scores = { 80, 90, 70, 100, 60 };

//int sum = 0;

//foreach (int score in scores)
//{
//    sum += score;
//}

//double average = (double)sum / scores.Length;

//Console.WriteLine(average);
#endregion


#region --Mini Challenge 1 — Positive Numbers--
//Given: //int[] numbers = { -5, 10, -3, 20, 0, 15, -8 };
//Use foreach to:
//Print only positive numbers.
//Count how many positive numbers there are.

//int[] numbers = { -5, 10, -3, 20, 0, 15, -8 };
//int count = 0;
//foreach (int number in numbers)
//{
//    if (number > 0)
//    {
//        Console.WriteLine(number);
//        count++;
//    }

//}
//Console.WriteLine($"The numbers of positive numbers are: {count}");
#endregion


#region --Mini Challenge 2 — Array Statistics--
//Given: int[] numbers = { 12, 5, 18, 7, 30, 14, 9 };
//Using foreach, find:
/*The largest number
The smallest number
The sum
The number of even values
*/

//int[] numbers = { 12, 5, 18, 7, 30, 14, 9 };
//int largest = numbers[0];
//int smallest = numbers[0];
//int sum = 0;
//int count = 0;
//foreach (int number in numbers)
//{
//    if (number > largest)
//    {
//        largest = number;

//    }
//    else if (number < smallest)
//    {
//        smallest = number;

//    }
//    else if (number % 2 == 0)
//    {
//        count++;

//    }

//    sum += number;

//}
//Console.WriteLine($"The largest number is: {largest}\n");
//Console.WriteLine($"The smallest number is: {smallest}\n");
//Console.WriteLine($"The number of even values: {count}\n");
//Console.WriteLine($"The sum of total values: {sum}");

#endregion


#region --Final Challenge — Student Scores--
//Imagine these are student scores: int[] scores = { 75, 92, 68, 88, 95, 71, 84 };
/*
Write a program that uses foreach to:

Print every score.
Find the highest score.
Find the lowest score.
Calculate the total.
Calculate the average.
Count how many students scored 80 or higher.
*/


//int[] scores = { 75, 92, 68, 88, 95, 71, 84 };
//int highest = scores[0];
//int lowest = scores[0];
//int total = 0;
//double average = 0;
//int count = 0;

//foreach (int score in scores)
//{
//    if (score > highest)
//    {
//        highest = score;
//    }
//    else if (score < lowest)
//    {
//        lowest = score;
//    }
//    else if (score >= 80)
//    {
//        count++;
//    }

//    total += score;
//}
//average = (double)total / scores.Length;
//Console.WriteLine($"The lowest score is: {lowest}\n");
//Console.WriteLine($"The highest score is: {highest}\n");
//Console.WriteLine($"The total score is: {total}\n");
//Console.WriteLine($"The average score is: {average}\n");
//Console.WriteLine($"The total count of students scored 80 or higher is: {count}");


#endregion


//C# Arrays — BOSS FIGHT

#region --C# Arrays — BOSS FIGHT--
//int[] scores = { 78, 92, 65, 88, 95, 72, 84, 59, 91, 76 };
/*
Your mission is to write a program using foreach that determines all of the following:

🎯 Requirements
Print every score.
Find the highest score.
Find the lowest score.
Calculate the total score.
Calculate the average score.
Count how many students scored 80 or higher.
Count how many students failed — score below 75.
*/


//int[] scores = { 78, 92, 65, 88, 95, 72, 84, 59, 91, 76 };

//int highest = scores[0];
//int lowest = scores[0];
//int total = 0;
//int countPass = 0;
//int countFail = 0;

//foreach (int score in scores)
//{
//    Console.WriteLine(score);

//    if (score > highest)
//    {
//        highest = score;
//    }

//    if (score < lowest)
//    {
//        lowest = score;
//    }

//    total += score;

//    if (score >= 80)
//    {
//        countPass++;
//    }
//    else if (score < 75)
//    {
//        countFail++;
//    }
//}

//double average = (double)total / scores.Length;

//Console.WriteLine($"Highest: {highest}");
//Console.WriteLine($"Lowest: {lowest}");
//Console.WriteLine($"Total score: {total}");
//Console.WriteLine($"Average score: {average}");
//Console.WriteLine($"Students scored 80 or higher: {countPass}");
//Console.WriteLine($"Students failed: {countFail}");
#endregion