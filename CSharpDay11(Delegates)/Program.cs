//CSharpFundamentals — Day 11: Delegates

class Program
{
    delegate void MyDelegate();
    static void SayHello()
    {
        Console.WriteLine("Hello, C#!");
    }

    delegate void GreetDelegate(string name);
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    delegate int MathDelegate(int a, int b);
    static int Add(int a, int b)
    {
        return a + b;
    }

    delegate int Compute(int a, int b);
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }


    static void Main()
    {
        #region --Mini Challenge 1 — Your First Delegate--

        //MyDelegate action = SayHello;

        //action();

        #endregion


        #region --Mini Challenge 2 — Delegate With Parameters--
        //GreetDelegate greeting = Greet;

        //greeting("Kiel");
        #endregion


        #region --Mini Challenge 3 — Delegate With Return Value--
        //MathDelegate operation = Add;

        //int result = operation(10, 5);
        //Console.WriteLine(result);
        #endregion


        #region --Mini Challenge 4 — Your Turn--
        Compute multi = Multiply; 
        Compute subs = Subtract;

        int product = multi(10, 5);
        Console.WriteLine(product);

        int difference = subs(10, 5);
        Console.WriteLine(difference);

        #endregion

    }

}





