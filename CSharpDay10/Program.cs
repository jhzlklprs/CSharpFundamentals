//CSharpFundamentals — Day 10: Dictionary<TKey, TValue>

#region --Mini Challenge 1 — Create a Dictionary--
//Create a dictionary called ages.
/*
It should contain:
"Kiel" → 25
"Anna" → 30
"Mark" → 22
*/

//Dictionary<string, int> ages = new Dictionary<string, int>();

//ages.Add("Kiel", 25);
//ages.Add("Anna", 30);
//ages.Add("Mark", 22);

//Console.WriteLine(ages["Kiel"]);

#endregion


#region --Mini Challenge 2 — Access Values--
//Using your ages dictionary, print:
//Try using string interpolation:

//Dictionary<string, int> ages = new Dictionary<string, int>();

//ages.Add("Kiel", 25);
//ages.Add("Anna", 30);
//ages.Add("Mark", 22);

//Console.WriteLine($"Anna's age: {ages["Anna"]}\n");
//Console.WriteLine($"Mark's age: {ages["Mark"]}\n");
#endregion


#region --Mini Challenge 3 — foreach--
//Now let's combine Dictionary + foreach.

//Dictionary<string, int> scores = new Dictionary<string, int>();

//scores.Add("Kiel", 95);
//scores.Add("Anna", 87);
//scores.Add("Mark", 76);
//scores.Add("John", 91);

//foreach (var item in scores)
//{
//    Console.WriteLine($"{item.Key}: {item.Value}");
//}

#endregion


#region --Dictionary Challenge — Boss Fight--
/*
Your mission:

Use foreach to print every item and its quantity.
Find the total quantity of all fruits.
Find the fruit with the highest quantity.
Print the result.
*/


//Dictionary<string, int> inventory = new Dictionary<string, int>();

//inventory.Add("Apple", 10);
//inventory.Add("Banana", 5);
//inventory.Add("Mango", 8);
//inventory.Add("Orange", 12);

//int total = 0;
//int highest = 0;
//string highestFruit = "";
//foreach (var fruits in inventory)
//{
//    Console.WriteLine($"Fruit: {fruits.Key}, Quantity: {fruits.Value}");

//    if (fruits.Value > highest)
//    {
//        highest = fruits.Value;
//        highestFruit = fruits.Key;
//    }

//    total += fruits.Value;
//}

//Console.WriteLine($"The total quantity of all fruits: {total}");
//Console.WriteLine($"The highest quantity: {highestFruit} ({highest})");
#endregion


//🥊 CSharpFundamentals — COLLECTIONS BOSS FIGHT

#region --COLLECTIONS BOSS FIGHT--
//🎮 Scenario: Student Score Manager

string[] names = { "Kiel", "Anna", "Mark", "John", "Lisa" };

List<int> scores = new List<int>();

scores.Add(95);
scores.Add(87);
scores.Add(76);
scores.Add(91);
scores.Add(88);

Dictionary<string, int> students = new Dictionary<string, int>();

students.Add(names[0], scores[0]);
students.Add(names[1], scores[1]);
students.Add(names[2], scores[2]);
students.Add(names[3], scores[3]);
students.Add(names[4], scores[4]);

int total = 0;
int count = 0;

int highest = 0;
string highestStudent = "";

int lowest = students[names[0]];
string lowestStudent = names[0];

foreach (var student in students)
{
    Console.WriteLine($"{student.Key} {student.Value}");

    total += student.Value;

    if (student.Value >= 75)
    {
        count++;
    }

    if (student.Value > highest)
    {
        highest = student.Value;
        highestStudent = student.Key;
    }
    if (student.Value < lowest)
    {
        lowest = student.Value;
        lowestStudent = student.Key;
    }

}

double average = (double)total / students.Count;

Console.WriteLine("\n");
Console.WriteLine($"Passing Students: {count}");
Console.WriteLine($"The total score: {total}");
Console.WriteLine($"Average: {average}");
Console.WriteLine($"Highest score: {highestStudent} {highest}");
Console.WriteLine($"Lowest score: {lowestStudent} {lowest}");
#endregion









