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



#region ----


#endregion



#region ----


#endregion