//🟦 CSharpFundamentals — Day 9: List<T>

#region --🧠 Mini Challenge 1 — Create a List--
//Create a list called: fruits

//List<string> fruits = new List<string>();

//fruits.Add("Apple");
//fruits.Add("Banana");
//fruits.Add("Mango");
//fruits.Add("Orange");

//foreach (string fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}

#endregion


#region --Mini Challenge 2 — Add and Remove--
//Create: List<string> names = new List<string>();

//List<string> names = new List<string>();

//names.Add("Kiel");
//names.Add("John");
//names.Add("Sarah");
//names.Add("Mike");

//names.Remove("Sarah");
//names.Add("David");

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//Console.WriteLine(names.Count);

#endregion


#region --🏆 Day 9 Challenge — Student Scores--
//Create: List<int> scores = new List<int>();
/*
Then use foreach to:

Print every score
Find the highest score
Find the lowest score
Calculate the total
Calculate the average
Count how many students passed (>= 75)
Count how many students failed (< 75)
*/


//List<int> scores = new List<int>();

//scores.Add(78);
//scores.Add(92);
//scores.Add(65);
//scores.Add(88);
//scores.Add(95);
//scores.Add(72);
//scores.Add(84);
//scores.Add(59);
//scores.Add(91);
//scores.Add(76);

//int highest = scores[0];
//int lowest = scores[0];
//int total = 0;
//int passed = 0;
//int failed = 0;
//foreach (int score in scores)
//{
//    Console.WriteLine(score);

//    if (score > highest)
//    {
//        highest = score;
//    }
//    if (score < lowest)
//    {
//        lowest = score;
//    }

//    total += score;

//    if (score >= 75)
//    {
//        passed++;
//    }
//    else
//    {
//        failed++;
//    }
//}
//double average = (double)total / scores.Count;
//Console.WriteLine($"Highest: {highest}");
//Console.WriteLine($"Lowest: {lowest}");
//Console.WriteLine($"Total score is: {total}");
//Console.WriteLine($"Average score is: {average}");
//Console.WriteLine($"Students passed: {passed}");
//Console.WriteLine($"Students failed: {failed}");
#endregion

#region --Exercise 1 — List basics--
// Create a List<string> of your 3 favorite foods. Then:

// Print the whole list
// Add one more food to it
// Remove the first food you added
// Print how many items are in the list now


List<string> FavoriteFoods = new()
{
    "Burger", "Pizza", "Taco"
};

FavoriteFoods.Add("Fries");
FavoriteFoods.Remove("Burger");

// foreach (var f in FavoriteFoods)
// {
//     Console.WriteLine(f);
// }

Console.WriteLine(FavoriteFoods.Count);


#endregion

#region --Exercise 2 — List searching--
// Create a List<int> with these numbers: 5, 12, 8, 21, 3, 19.

// Check if 21 is in the list (print true/false)
// Find and print the largest number in the list
// Print the number at index 2
#endregion

#region --Exercise 3 — Dictionary basics--
// Create a Dictionary<string, int> representing 3 students and their scores (e.g., "Anna", 85).

// Print Anna's score using her name as the key
// Add a new student
// Check if a student called "Mark" exists in the dictionary befsore trying to access him (avoid a crash)
#endregion

#region --Exercise 4 — Combining List + Dictionary--
// Create a Dictionary<string, List<int>> — imagine it's each student's list of quiz scores, e.g. "Anna", [90, 85, 95].

// Print all of Anna's scores
// Add a new score to Anna's list
// Print the average of Anna's scores
#endregion

#region ----

#endregion

#region ----

#endregion

#region ----

#endregion