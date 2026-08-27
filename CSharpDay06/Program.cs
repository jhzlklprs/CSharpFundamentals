//C# Fundamentals — Day 6: Methods 🧩

#region --Exercise 1 — Simple Method--
//Create a method called: SayHello
//static void SayHello()
//{
//    Console.WriteLine("Hello, C#!");
//}
//SayHello();
#endregion

#region --Exercise 2 — Parameter--
//Create: Greet(string name)

//static void Greet(string name)
//{
//    Console.WriteLine($"Hello, {name}");
//}
//Greet("Kiel");
#endregion

#region --Exercise 3 — Two Parameters--
//Create: Add(int a, int b)

//static int Add(int a, int b)
//{
//    return a + b;
//}

//int result = Add(10, 20);
//Console.WriteLine(result);
#endregion

#region --Exercise 4 — Boolean Method--
//Create: IsAdult(int age)

//static bool IsAdult(int age)
//{
//    return age >= 18;
//}
//Console.WriteLine(IsAdult(18));

#endregion

#region --Mini Challenge--
//Create a method: GetGrade(int score)
/*
It should return:

90–100 → "Excellent"
75–89 → "Passed"
Below 75 → "Failed"
*/

static string GetGrade(int score)
{
    if (score >= 90)
    {
        return "Excellent";
    }
    else if (score >= 75)
    {
        return "Passed";
    }
    else
    {
        return "Failed";
    }
}

Console.WriteLine(GetGrade(90));

#endregion

#region ----

#endregion