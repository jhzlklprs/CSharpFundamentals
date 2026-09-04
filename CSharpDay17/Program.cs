//CSharpFundamentals — Day 17: LINQ

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