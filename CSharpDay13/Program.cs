//CSharpFundamentals — Day 13: Func<T>


#region --Day 13 — Mini Challenge 1--
//Create a Func that calculates the square of a number.
//static int Square(int number)
//{
//    return number * number;
//}

//Func<int, int> sqr = Square;
//Console.WriteLine(Square(5));
#endregion


#region --Mini Challenge 2 — Add Two Numbers--

//static int Add(int a, int b)
//{
//    return a + b;
//}

//Func<int, int, int> sum = Add;
//Console.WriteLine(sum(10, 20));

#endregion


#region --Mini Challenge 3 — Student Grade--

static string GetGrade(int score)
{

    if (score >= 90)
    {

        Console.WriteLine($"Score: {score}\n");
        return "A";

    }
    else if (score >= 80 && score <= 89)
    {
        Console.WriteLine($"Score: {score}\n");
        return "B";
    }
    else if (score >= 70 && score <= 79)
    {
        Console.WriteLine($"Score: {score}\n");
        return "C";
    }
    else if (score >= 60 && score <= 69)
    {
        Console.WriteLine($"Score: {score}\n");
        return "D";
    }
    else
    {
        Console.WriteLine($"Score: {score}\n");
        return "F";

    }

}

Func<int, string> studentGrade = GetGrade;
string grade = studentGrade(90);

Console.WriteLine($"Grade: {grade}");
//I'm stuck, thinking using switch???

#endregion


#region ----

#endregion


#region ----

#endregion


#region ----

#endregion