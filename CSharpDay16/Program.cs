//CSharpFundamentals — Day 16: Generics


#region --Mini Challenge 1 — Your Turn--

//static void Display<T>(T value)
//{
//    Console.WriteLine(value);
//}

//Display<int>(100);
//Display<string>("Hello");
//Display<double>(99.5);
#endregion


#region --Mini Challenge 2 — Generic Class--

//        Box<int> intBox = new Box<int>();
//        intBox.Value = 500;

//        Box<string> stringBox = new Box<string>();
//        stringBox.Value = "C# Generics";

//        Console.WriteLine(intBox.Value);
//        Console.WriteLine(stringBox.Value);

//class Box<T>
//{
//    public T Value { get; set; }
//}


#endregion


#region --Mini Challenge 3 — Two Generic Types--

//Pair<string, int> student = new Pair<string, int>();

//student.First = "Kiel";
//student.Second = 95;

//Console.WriteLine(student.First);
//Console.WriteLine(student.Second);

//class Pair<T1, T2>
//{
//    public T1 First { get; set; }
//    public T2 Second { get; set; }
//}


#endregion


#region --Mini Challenge 4 — Generic Method with Two Types--

//static void ShowPair<T1, T2>(T1 first, T2 second)
//{
//    Console.WriteLine(first);
//    Console.WriteLine(second);
//}


//ShowPair<string, int>("Kiel", 95);
//ShowPair<string, double>("C#", 99.5);

#endregion


#region --Mini Challenge 5 — Generic Constraint--
////Create a generic method:

//static void PrintNumber<T>(T value) where T : struct
//{
//    Console.WriteLine(value);
//}

//PrintNumber<int>(100);
//PrintNumber<double>(99.5);
#endregion



#region --Boss Fight — Generic Compare--

static void Compare<T>(T first, T second) where T : IComparable<T>
{
    int result = first.CompareTo(second);

    if (result > 0)
    {
        Console.WriteLine("first is greater");
    }
    else if (result < 0)
    {
        Console.WriteLine("second is greater");
    }
    else
    {
        Console.WriteLine("They are equal");
    }
}

Compare<int>(10, 20);
Compare<double>(99.5, 50.5);
Compare<string>("Apple", "Banana");
Compare<int>(100, 100);

#endregion


#region ----


#endregion