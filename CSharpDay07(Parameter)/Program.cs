//Part 1 — What is a Parameter?

#region --Exercise 1 — One Parameter--
//Create a method called: PrintNumber

//static string PrintNumber(int number)
//{
//    return $"The number is: {number}";
//}
//Console.WriteLine(PrintNumber(10));
#endregion


#region --Exercise 2 — Multiple Parameters--
//Create: AddNumbers


//static int AddNumbers(int a, int b)
//{
//    return a + b;
//}
//Console.WriteLine(AddNumbers(5, 3));
#endregion


#region --Exercise 3 — Calculate Total--
//Create a method called: CalculateTotal

//static double CalculateTotal(double price, int quantity)
//{
//    return price * quantity;
//}
//Console.WriteLine(CalculateTotal(50.5, 3));
#endregion


#region --Exercise 4 — Personalized Message--
//Create a method called: CreateMessage

//static string CreateMessage(string name, int age)
//{
//    return $"Hello {name}, you are {age} years old.";
//}
//Console.WriteLine(CreateMessage("Kiel", 28));
#endregion


#region --Exercise 5 — Method + if/else--
//Create a method called: CheckAge

//static string CheckAge(int age)
//{
//    if (age >= 18)
//    {
//        return "You are an adult.";
//    }
//    else
//    {
//        return "You are a minor.";
//    }
//}
//Console.WriteLine(CheckAge(20));
#endregion



#region --Day 7 Challenge — Simple Calculator--
//Create a method: Calculate
/*
+  → addition
-  → subtraction
*  → multiplication
/  → division
*/

static double Calculate(double a, double b, char operation)
{
    switch (operation)
    {
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        case '/':
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        default:
            throw new InvalidOperationException("Invalid operation.");
    }
}
Console.WriteLine(Calculate(10, 5, '+'));
#endregion





#region ----

#endregion