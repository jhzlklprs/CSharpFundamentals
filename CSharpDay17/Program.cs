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


#endregion


#region -- Sum() Mini Challenges 🧮 --

// List<int> numbers = new List<int>
// {
//     10, 20, 30, 40
// };

// int result = numbers.Sum();

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 1 — Sum All --

// List<int> numbers = new List<int>
// {
//     5, 10, 15, 20
// };

// int result = numbers.Sum();

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 2 — Sum With Transformation --

// List<int> numbers = new List<int>
// {
//     2, 4, 6, 8
// };

// int result = numbers.Sum(n => n * 3);

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 3 — Sum Only Matching Values --

// List<int> numbers = new List<int>
// {
//     5, 10, 15, 20, 25, 30
// };

// int result = numbers.Where(n => n > 15).Sum();

// Console.WriteLine(result);


#endregion


#region -- Mini Challenge 4 — Student Scores --

// List<int> scores = new List<int>
// {
//     85, 92, 76, 88, 95
// };

// int result = scores.Sum();

// Console.WriteLine(result);

#endregion


#region -- Mini Challenge 5 — Boss Fight 😈 --

List<int> numbers = new List<int>
{
    10, 15, 22, 31, 40, 55, 62, 73, 80
};

int result = numbers.Where(n => n > 20 && n % 2 == 0 ).Sum();


Console.WriteLine(result);

#endregion

















