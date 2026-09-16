//CSharpFundamentals — Day 11: Delegates

#region -- DELEGATES --
// class Program
// {
//     delegate void MyDelegate();
//     static void SayHello()
//     {
//         Console.WriteLine("Hello, C#!");
//     }

//     delegate void GreetDelegate(string name);
//     static void Greet(string name)
//     {
//         Console.WriteLine($"Hello, {name}!");
//     }

//     delegate int MathDelegate(int a, int b);
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     delegate int Compute(int a, int b);
//     static int Multiply(int a, int b)
//     {
//         return a * b;
//     }

//     static int Subtract(int a, int b)
//     {
//         return a - b;
//     }


//     static void Main()
//     {
//         #region --Mini Challenge 1 — Your First Delegate--

//         //MyDelegate action = SayHello;

//         //action();

//         #endregion


//         #region --Mini Challenge 2 — Delegate With Parameters--
//         //GreetDelegate greeting = Greet;

//         //greeting("Kiel");
//         #endregion


//         #region --Mini Challenge 3 — Delegate With Return Value--
//         //MathDelegate operation = Add;

//         //int result = operation(10, 5);
//         //Console.WriteLine(result);
//         #endregion


//         #region --Mini Challenge 4 — Your Turn--
//         Compute multi = Multiply; 
//         Compute subs = Subtract;

//         int product = multi(10, 5);
//         Console.WriteLine(product);

//         int difference = subs(10, 5);
//         Console.WriteLine(difference);

//         #endregion

//     }

// }

#region -- DELEGATES PRACTICE --

#endregion



// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(add(5, 10));
//     }

//     delegate int Operation (int a, int b);

//     static Operation add = Add;

//     static int Add (int a, int b) => a + b;
// }

#endregion


#region -- C# Focus Learning Material [Delegates Practice Set] --
//Part 1 — Action

//Exercise 1 — Basic Action
// Action greet = ShowWelcome;

// greet();

// static void ShowWelcome()
// {
//     Console.WriteLine("Welcome to C#!");
// }

//Exercise 2 — Action With a Parameter
// Action<string> greet = GreetStudent;

// greet("Kiel");

// static void GreetStudent(string name)
// {
//     Console.WriteLine($"Hello, {name}!");
// }

//Exercise 3 — Action With Multiple Parameters
// Action<string, int> display = DisplayStudent;

// display("Kiel", 95);

// static void DisplayStudent(string name, int score)
// {
//     Console.WriteLine($"{name} scored {score}");
// }

//Part 2 — Func

//Exercise 4 — Square
//Exercise 5 — Add Two Numbers
// class Program
// {
//     static Func<int, int> sqr = Square;
//     static Func<int, int, int> add = Add;
//     static void Main()
//     {

//         Console.WriteLine(sqr(10));
//         Console.WriteLine(add(10,20));
//     }

//     static int Square (int number)
//         {
//             return number * number;
//         }

//     static int Add (int a, int b)
//     {
//         return a + b;
//     }

// }


// class Program
// {
//     // static Func<int,int,int> Add = (a,b) => a + b; 
//     // static Func<int,int,int> Multiply = (a,b) => a * b; 
//     // static Func<int,int,int> Subtract = (a,b) => a - b; 
//     static void Main()
//     {
//         // Console.WriteLine(Add(10,20));
//         // Console.WriteLine(Multiply(10,20));
//         // Console.WriteLine(Subtract(10,20));

//         Console.WriteLine(Calculate(10,5, Add));
//         Console.WriteLine(Calculate(10,5,Multiply));
//         Console.WriteLine(Calculate(10,5,Subtract));
//     }


//     static int Calculate (int x, int y, Func<int,int,int> operation)
//     {
//         return operation(x, y);
//     }

//     static int Add(int a, int b) => a + b;
//     static int Multiply(int a, int b) => a * b;
//     static int Subtract(int a, int b) => a - b;
// }



// Exercise 8 — Multiple Notifications


static void LogToConsole(string message)
{
    Console.WriteLine($"Console: {message}");
}

static void SaveToFile(string message)
{
    Console.WriteLine($"File: {message}");
}

static void SendEmail(string message)
{
    Console.WriteLine($"Email: {message}");
}





















#endregion