//CSharpDay02

#region --Arithmethic Operators--

//int a = 10;
//int b = 3;

//Console.WriteLine(a + b); //13
//Console.WriteLine(a - b); //7
//Console.WriteLine(a * b); //30
//Console.WriteLine(a / b); //3
//Console.WriteLine(a % b); //1

//int x = 20;
//int y = 6;

//Console.WriteLine (x + y); //26
//Console.WriteLine(x - y); //14
//Console.WriteLine(x * y); //120
//Console.WriteLine(x / y); //3
//Console.WriteLine(x % y); //

#endregion


#region --Comparison Operators--

//int age = 20;

//Console.WriteLine(age == 20); //True
//Console.WriteLine(age != 20); //False
//Console.WriteLine(age > 18);   // True
//Console.WriteLine(age < 18);   // False
//Console.WriteLine(age >= 20);  // True
//Console.WriteLine(age <= 19);  // False

#endregion


#region --Logical Operators--

// && (AND)
//int age = 25;
//bool hasTicket = true;

//Console.WriteLine(age >= 18 && hasTicket);

// || (OR)
//int score = 40;

//Console.WriteLine(score >= 75 || score >= 50); // False

//int score = 80;

//Console.WriteLine(score >= 75 || score >= 50); //True

// ! (NOT)
//bool isLoggedIn = true;

//Console.WriteLine(!isLoggedIn); //False

//bool isAdmin = false;

//Console.WriteLine(!isAdmin); //True

#endregion


#region --Assignment Operators--

//int x = 10;

//x += 5;   // 15
//x -= 3;   // 12
//x *= 2;   // 24
//x /= 6;   // 4
//x %= 3;   // 1

//Console.WriteLine(x);

#endregion


#region --Increment and Decrement Operators (++ and --)--

//int lives = 3;

//lives++;
//lives++;

//Console.WriteLine(lives);

#endregion


#region --Day 2 Final Challenge--

int score = 50;
int bonus = 15;
bool isMember = true;

score += bonus;
score *= 2;

bool passed = score >= 1 && isMember;

#endregion