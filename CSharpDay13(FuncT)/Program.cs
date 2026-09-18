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

// using System.ComponentModel;

// static string GetGrade(int score)
// {

//     if (score >= 90)
//     {

//         Console.WriteLine($"Score: {score}\n");
//         return "A";

//     }
//     else if (score >= 80 && score <= 89)
//     {
//         Console.WriteLine($"Score: {score}\n");
//         return "B";
//     }
//     else if (score >= 70 && score <= 79)
//     {
//         Console.WriteLine($"Score: {score}\n");
//         return "C";
//     }
//     else if (score >= 60 && score <= 69)
//     {
//         Console.WriteLine($"Score: {score}\n");
//         return "D";
//     }
//     else
//     {
//         Console.WriteLine($"Score: {score}\n");
//         return "F";

//     }

// }

// Func<int, string> studentGrade = GetGrade;
// string grade = studentGrade(90);

// Console.WriteLine($"Grade: {grade}");
//I'm stuck, thinking using switch???

#endregion


#region ----

#endregion


#region ----

#endregion


#region --Exercise: Mini Calculator with Lambdas--
// Mission: Build a small console calculator that uses Func<int, int, int> lambdas instead of named methods for each operation.

// Requirements:

// Declare four Func<int, int, int> variables: add, subtract, multiply, divide — each assigned a lambda.
// Store them in a Dictionary<string, Func<int, int, int>> keyed by "+", "-", "*", "/".
// Ask the user for two numbers and an operator symbol.
// Look up the right lambda from the dictionary and run it, printing the result.
// If the operator isn't in the dictionary, print an error message instead of crashing.

// Stretch goal: Make the "/" lambda a multi-statement lambda (with braces) that checks for divide-by-zero and returns -1 (or throws a message) instead of crashing.



class Program
{
    static void Main()
    {
        Func<int,int,int> Add = (a,b) => a + b;
Func<int,int,int> Subtract = (a,b) => a - b;
Func<int,int,int> Multiply = (a,b) => a * b;
Func<int,int,int> Divide = (a,b) => 
{
    if ( b == 0)
    {
        Console.WriteLine("Error: Cannot divide by zero.");
        return -1;
    }
    return a / b;
};

Console.WriteLine("Welcome to Console Calculator made with Delegates");

Dictionary<string, Func<int,int,int>> Operator = new()
{
    {"+", Add},
    {"-", Subtract},
    {"*", Multiply},
    {"/", Divide}

};

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Select an operator: +, -, *, / ");
string select = Console.ReadLine();

if (Operator.ContainsKey(select))
{
    double result = Operator[select](a, b);
    Console.WriteLine($"Operation: {a} {select} {b}");
            Console.WriteLine($"Result: {result}");
}
else
{
    Console.WriteLine("Invalid operator selected.");
}

    }
}



#endregion