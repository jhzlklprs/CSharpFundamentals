//CSharpFundamentals — Day 12: Action

#region --Basic Action--
//static void SayHello()
//{
//    Console.WriteLine("Hello, C#!");
//}

//Action del = SayHello;
//del();
#endregion

#region --Action with Parameters--
////Greet
//static void Greet(string name)
//{
//    Console.WriteLine($"Hello, {name}!");
//}
//Action<string> greetAction = Greet;
//greetAction("Kiel");

////DisplayInfo
//static void DisplayInfo(string name, int age)
//{
//    Console.WriteLine($"{name} is {age} years old.");
//}
//Action<string, int> infoAction = DisplayInfo;
//infoAction("Kiel", 28);
#endregion

#region --Day 12 — Mini Challenge 1--
//Create a method: SayGoodbye()

//static void SayGoodBye()
//{
//    Console.WriteLine("Goodbye, C#!");
//}

//Action greetAction = SayGoodBye;
//greetAction();

#endregion

#region --Mini Challenge 2 — Parameter--
//Create: Welcome(string name)

//static void Welcome(string name)
//{
//    Console.WriteLine($"Welcome, {name}!");
//}
//Action<string> greet = Welcome;
//greet("Kiel");
#endregion

#region --Mini Challenge 3 — Two Parameters--
//Create: AddAndPrint(int a, int b)

//static void AddAndPrint(int a, int b)
//{
//    int result = a + b;
//    Console.WriteLine($"The sum of {a} and {b} is: {result}");
//}

//Action<int, int> sum = AddAndPrint;
//sum(10, 20);
#endregion

#region --CSharpFundamentals — Day 12 Action Boss Fight--
//Scenario: Student Notification System

using System.Xml.Linq;

List<string> students = new List<string>
{
    "Kiel",
    "Anna",
    "Mark",
    "John",
    "Lisa"
};

foreach (string student in students)
{
    NotifyStudent(student);
}

Action<string> notify = NotifyStudent;

static void NotifyStudent(string name)
{

    Console.WriteLine($"Hello, {name}! Your assignment is ready.");

}


#endregion
