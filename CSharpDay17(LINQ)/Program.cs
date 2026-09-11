//CSharpFundamentals — Day 17: LINQ

#region -- LINQ --

#region --First: What is LINQ? // LINQ = Language Integrated Query--
//For example, without LINQ:
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//foreach (int number in numbers)
//{
//    if(number > 3)
//    {
//        Console.WriteLine(number);
//    }
//}


//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//var result = numbers.Where(number => number > 3);

//foreach (int number in result)
//{
//    Console.WriteLine(number);
//}
#endregion


#region --Mini Challenge 1: Where()--

//List<int> numbers = new List<int>
//{
//    10,15,20,25,30,35,40
//};

//var result = numbers.Where(n => n > 25);

//foreach (int res in result)
//{
//    Console.WriteLine(res);
//}
#endregion


#region --Mini Challenge 2 — Select()--
//Now we're going to learn the second major LINQ method: Select().

//List<int> numbers = new List<int>
//{
//    1,2,3,4,5
//};

//var result = numbers.Select(n => n * 10);

//foreach (int res in result)
//{
//    Console.WriteLine(res);
//}

#endregion


#region --Mini Challenge 3 — Chain Where() + Select()--

//List<int> numbers = new List<int>
//{
//    5,10,15,20,25,30
//};

//var result = numbers
//    .Where(n => n > 15)
//    .Select(a => a * 2);


//foreach (int res in result)
//{
//    Console.WriteLine(res);
//}
#endregion


#region --Mini Challenge 4 — OrderBy()--

//List<int> numbers = new List<int>
//{
//    50,10,40,20,30
//};

//var result = numbers.OrderBy(n => n).ToList();

//foreach (int res in result)
//{
//    Console.WriteLine(res);
//}


#endregion


#region --Mini Challenge 5 — Combine 3 LINQ methods--

//List<int> numbers = new List<int>
//{
//    5, 30, 15, 40, 10, 25, 20
//};

//var result = numbers.Where(n => n > 15)
//.Select(n => n * 2)
//.OrderBy(n => n);

//foreach (int res in result)
//{
//    Console.WriteLine(res);
//}
#endregion


#region --Exercise 1 — Filter--

//List<int> numbers = new List<int>
//{
//    3,8,12,17,21,26,30
//};

//var result = numbers.Where(n => n > 15);

//foreach (int res in result)
//{
//    Console.WriteLine(res);
//}

#endregion


#region --Exercise 2 — Transform--

//List<int> numbers = new List<int>
//{
//    2,4,6,8,10
//};

//var result = numbers.Select(n => n + 5);

//foreach(int res in result)
//{
//    Console.WriteLine(res);
//}

#endregion


#region --Exercise 3 — Sort--

//List<int> numbers = new List<int>
//{
//    45,10,30,5,25,15
//};

//var result = numbers.OrderBy(n => n);

//foreach( int res in result)
//{
//    Console.WriteLine(res);
//}
#endregion


#region --Exercise 4 — Filter + Transform--

//List<int> numbers = new List<int>
//{
//    5,10,15,20,25,30
//};

//var result = numbers.Where(currentNumber => currentNumber > 10)
//.Select(value => value * 3);

//foreach(int res in result)
//{
//    Console.WriteLine(res);
//}
#endregion


#region --Exercise 5 — Full Pipeline--

//List<int> numbers = new List<int>
//{
//    12, 5, 30, 18, 7, 25, 40, 10
//};

//var result = numbers.Where(currentNumbers => currentNumbers > 10)
//.Select(value => value * 2)
//.OrderBy(sortby => sortby);

//foreach(int res in result)
//{
//    Console.WriteLine(res);
//}
#endregion


#region --Mini Challenge 6 — First()--

//List<int> numbers = new List<int>
//{
//    5, 12, 18, 25, 30, 42
//};

//var result = numbers.First(n => n > 20);

//    Console.WriteLine(result);

#endregion


#region -- Mini Challenge 7 - FirstOrDefault() --

// List<int> numbers = new List<int>
// {
//    10, 20, 30, 40, 50
// };

// var a = numbers.First(n => n > 25);
// var b = numbers.FirstOrDefault(n => n > 100);
// var c = numbers.FirstOrDefault();
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
#endregion


#region -- Mini Challenge 8 — Any() --

// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// bool result = numbers.Any(n => n > 3);

// Console.WriteLine("ANY RESULT: " + result);

#endregion


#region -- Mini Challenge 9 — All() --

// List<int> numbers = new List<int> { 2, 4, 6, 8};

// bool result = numbers.All(n => n % 2 == 0);

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 1 — Any() --

// List<int> numbers = new List<int> { 5, 12, 8, 3, 20};

// bool result = numbers.Any(n => n > 15);

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 2 — All() --

// List<int> numbers = new List<int> { 10, 20, 30, 40 };

// bool result = numbers.All(n => n > 5);

// Console.WriteLine(result);


#endregion


#region -- LINQ Count() --

// List<int> numbers = new List<int>
// {
//     10,20,30,40,50
// };

// int result = numbers.Count(n => n > 25);

// Console.WriteLine(result);


#endregion


#region -- Mini Challenge 1 — Count All --

// List<int> numbers = new List<int>
// {
//   10, 20, 30, 40, 50  
// };

// int result = numbers.Count();

// Console.WriteLine(result);
#endregion



#region -- Mini Challenge 2 — Count With Condition --

// List<int> numbers = new List<int>
// {
//   5, 12, 18, 25, 30, 42  
// };

// int result = numbers.Count(n => n > 20);

// Console.WriteLine(result);


#endregion



#region -- Mini Challenge 3 — Count Even Numbers --

// List<int> numbers = new List<int>
// {
//   1,2,3,4,5,6,7,8  
// };

// int result = numbers.Count(n => n % 2 == 0);

// Console.WriteLine(result);

#endregion



#region -- Mini Challenge 4 — Student Scores --

// List<int> scores = new List<int>
// {
//     95, 72, 88, 60, 45, 91, 78
// };

// int result = scores.Count(n => n > 75);

// Console.WriteLine(result);

#endregion



#region -- Mini Challenge 5 — Boss Fight 😈 --

// List<int> numbers = new List<int>
// {
//     10, 15, 22, 31, 40, 55, 62, 73, 80
// };

// int result = numbers.Count(n => n > 20 && n % 2 == 0);

// Console.WriteLine(result);
#endregion


#region -- 😈 Now your Boss Fight --

// List<int> numbers = new List<int>
// {
//     10, 15, 22, 30, 41, 50, 63, 70
// };

// var result = numbers.Where(n => n > 20 && n % 2 == 0).Sum();

// Console.WriteLine(result);


#endregion

#region #region -- 1. Select — Projection --

#region -- Mini Challenge 1.1 — Square Them --

// List<int> numbers = new List<int>
// {
//   1, 2, 3, 4, 5  
// };

// var result = numbers.Select(n => n * n);

// foreach(var r in result)
// {
//     Console.WriteLine(r);
// }

#endregion

#region -- Mini Challenge 1.2 — Names to Lengths --

// List<string> names = new List<string>
//  { "Ana", "Chris", "Bo", "Alexander" };

//  var result = names.Select(n => n.Length);

//  foreach (var r in result)
// {
//     Console.WriteLine(r);
// }

#endregion

#region -- Mini Challenge 1.3 — Project to a New Shape --

// List<double> prices = new List<double> { 5, 19.99, 100};

// var result = prices.Select(n => $"${n:F2}");

// foreach (var r in result)
// {
//     Console.WriteLine(r);
// }
#endregion

#endregion

#region -- 2. SelectMany — Flattening --

#region -- Mini Challenge 2.1 — Flatten Class Lists --

// List<List<string>> classrooms = new List<List< string>>
// {
//     new List<string> { "Mia", "Leo" },
//     new List<string> { "Sam", "Ivy", "Tom" },
//     new List<string> { "Nora" }
// };

// var result = classrooms.SelectMany( c => c);

// foreach (var r in result)
// {
//     Console.WriteLine(r);
// }


#endregion

#region -- Mini Challenge 2.2 — Flatten and Transform --

// List<string> words = new List<string> { "cat", "dog" };

// var result = words.SelectMany(c => c);

// foreach(var r in result)
// {
//     Console.WriteLine(r);
// }

#endregion

#endregion


#region -- Mini Challenge 1 — Basic Average --

// List<int> numbers = new List<int>
// {
//   10, 20, 30, 40, 50  
// };

// double result = numbers.Average();

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 2 — Average with a Condition --

// List<int> scores = new List<int>
// {
//     50, 60, 70, 80, 90, 100
// };

// double result = scores.Where(n => n > 70).Average();

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 3 — Average of Even Numbers --

// List<int> numbers = new List<int>
// {
//     10, 15, 20, 25, 30, 35, 40
// };

// double result = numbers.Where(n => n % 2 == 0).Average();

// Console.WriteLine(result);

#endregion


#region -- 😈 Mini Challenge 4 — Student Scores --

//List<int> scores = new List<int>
// {
//     95, 72, 88, 60, 45, 91, 78
// };

//var result = scores.Where(n => n >= 75).Average();

//Console.WriteLine(result);
#endregion


#region -- 😈 Mini Challenge 5 — Average Boss Fight --


#region -- Mini Challenge 1 — Min --

// List<int> numbers = new List<int>
// {
//     42, 17, 89, 5, 63, 24
// };

// int result = numbers.Min();

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 2 — Max --

// List<int> numbers = new List<int>
// {
//     42, 17, 89, 5, 63, 24
// };

// int result = numbers.Max();

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 3 — Find the Maximum --

// List<int> numbers = new List<int>
// {
//     42, 17, 89, 5, 63, 24
// };

// int max = numbers [0];

// for (int i = 1; i < numbers.Count; i++)
// {
//     if(numbers[i] > max)
//     {
//         max = numbers[i];
//     }
// }

// Console.WriteLine(max);

#endregion


#region -- Mini Challenge 4 — Find the Minimum --

// List<int> numbers = new List<int>
// {
//     42, 17, 89, 5, 63, 24
// };

// int min = numbers [0];

// for(int i = 1; i < numbers.Count; i++)
// {
//     if(numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }

// Console.WriteLine(min);


#endregion 


#region -- Mini Challenge 5 — Accumulator --

// List<int> numbers = new List<int>
// {
//     10, 20, 30, 40, 50
// };

// int initialValue = 0;


// foreach(var n in numbers)
// {
//     initialValue += n ;
// }

// Console.WriteLine(initialValue);

#endregion 


#region -- Mini Challenge 6 — Counter --

// List<int> numbers = new List<int>
// {
//     10, 25, 30, 7, 42, 15, 60
// };

// int count = 0;
// foreach (var n in numbers)
// {
//     if (n > 20)
//     {
//         count++;
//     }


// }
//     Console.WriteLine(count);
#endregion


#region -- Mini Challenge 7 — Combine Patterns --

// List<int> numbers = new List<int>
// {
//     10, 25, 30, 7, 42, 15, 60
// };

// int total = 0;
// int count = 0;

// foreach (var n in numbers)
// {
//     if (n > 20)
//     {
//         total += n;
//         count++;
//     }
// }

// double average = (double)total / count;

// Console.WriteLine(average);
#endregion


#region -- Mini Challenge 8 — Find the Second Largest --

// List<int> numbers = new List<int>
// {
//     42, 17, 89, 5, 63, 24
// };

// int max = numbers [0];
// int secondMax = numbers [0];

// for (int i = 1; i < numbers.Count; i++)
// {
//     if(numbers[i] > max)
//     {
//         secondMax = max;
//         max = numbers[i];
//     }
//     else if(numbers[i] > secondMax)
//     {
//          secondMax = numbers[i];
//     }

// }
// Console.WriteLine(max);
// Console.WriteLine(secondMax);
#endregion



#endregion



// List<int> numbers = new List<int>
// {
//    12, 18, 25, 30, 35, 42, 50, 61, 70
// };

// var result = numbers.Where(n => n > 20 && n % 2 == 0).Average();

// Console.WriteLine(result);
#endregion

#region -- LINQ Method — Single() --

// List<int> numbers = new List<int>
// {
//     10, 20, 30, 40, 50
// };

// int result = numbers.Single(n => n == 30);

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 9 — Single() --

// List<string> students = new List<string>
// {
//     "Anna",
//     "Mark",
//     "John",
//     "Lisa"
// };

// var result = students.Single(s => s == "John");

// Console.WriteLine(result);
#endregion


#region -- Mini Challenge 10 — SingleOrDefault() --

// List<string> students = new List<string>
// {
//     "Anna",
//     "Mark",
//     "John",
//     "Lisa"
// };

// var result = students.SingleOrDefault(s => s == "David");

// if (result == null)
// {
//     Console.WriteLine("Result is Empty, can't find student David!");
// }
// else
// {
//     Console.WriteLine(result);
// }

#endregion


#region -- Mini Challenge 11 — Last() --

// List<int> numbers = new List<int>
// {
//     10, 20, 30, 40, 50
// };

// var result = numbers.Last(n => n > 20);

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 12 — LastOrDefault() --

List<int> numbers = new List<int>
{
    10, 20, 30, 40, 50
};

var result = numbers.LastOrDefault(n => n > 100);

Console.WriteLine(result);

#endregion





















