//CSharpFundamentals — Day 12: Action
#region -- ACTION -- 
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


// List<string> students = new List<string>
// {
//     "Kiel",
//     "Anna",
//     "Mark",
//     "John",
//     "Lisa"
// };

// foreach (string student in students)
// {
//     NotifyStudent(student);
// }

// Action<string> notify = NotifyStudent;

// static void NotifyStudent(string name)
// {

//     Console.WriteLine($"Hello, {name}! Your assignment is ready.");

// }


#endregion

#endregion


#region -- PRACTICE 1 --

// List<string> students = new List<string>
// {
//     "Kiel",
//     "Anna",
//     "Mark",
//     "John",
//     "Lisa"
// };

// Action<string> greet = name => Console.WriteLine($"Hello {name}");

// foreach (var s in students)
// {
//     greet(s);
// }


#endregion


#region -- PRACTICE 2 --

// Exercise: Multi-parameter Action
// Write an Action<string, int> that prints something like:
// Kiel is 21 years old
// Requirements:
// Declare an Action<string, int> called describePerson using a lambda.
// Create a list of tuples (or two parallel lists) with a few names and ages, for example:

//    var people = new List<(string Name, int Age)>
//    {
//        ("Kiel", 21),
//        ("Anna", 25),
//        ("Mark", 30)
//    };

// Action<string, int> describePerson = (name , age) => Console.WriteLine($"{name} is {age} years old");


// foreach (var p in people)
// {
//     describePerson(p.Name, p.Age);
// }

#endregion


#region -- PRACTICE 3 --

// Exercise: Func instead of Action
// Rewrite describePerson as a Func<string, int, string> called buildDescription.
// Instead of printing directly inside the lambda, it should RETURN the sentence.
// Requirements:
// - Declare buildDescription as Func<string, int, string>
// - The lambda returns something like "Kiel is 21 years old" (no Console.WriteLine inside the lambda)
// - Loop through `people` again, call buildDescription(p.Name, p.Age) to get the string,
//   then print it yourself in the loop

// var people = new List<(string Name, int Age)>
//    {
//        ("Kiel", 21),
//        ("Anna", 25),
//        ("Mark", 30)
//    };


// Func<string, int, string> buildDescription = (name, age) => $"{name} is {age} years old";

// foreach (var p in people)
// {
//     string description = buildDescription(p.Name, p.Age);
//     Console.WriteLine(description);
// }

#endregion



#region -- PRACTICE 4 --

// Exercise: Func + LINQ
// Use buildDescription (or a similar Func<string,int,string>) together with LINQ's Select
// to transform the whole `people` list into a List<string> of descriptions,
// without writing a foreach loop yourself.
// Requirements:
// - Use people.Select(...) with a lambda that calls buildDescription
// - Convert the result to a List<string> called descriptions
// - Print each item in descriptions however you like (foreach is fine for just printing)











#endregion