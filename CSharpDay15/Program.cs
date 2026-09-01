//CSharpFundamentals — Day 15: Error Handling


#region --Mini Challenge 1 — Catch the Error--

//Console.WriteLine("Enter a number: ");
//string name = Console.ReadLine();

//try
//{

//    Convert.ToInt16(name);
//    Console.WriteLine(name);
//}
//catch (FormatException)
//{
//    Console.WriteLine("Invalid number!");
//}
#endregion

#region --Sample--
//try
//{
//    Console.WriteLine("Enter your age: ");
//    int age = int.Parse(Console.ReadLine()!);
//}
//catch (FormatException)
//{
//    Console.WriteLine("That's not a valid number.");
//}
#endregion

#region --Day 15 Mini Boss--
////Simple ATM
//int balance = 1000;

//Console.WriteLine($"Balance: {balance}");
//try
//{
//    Console.WriteLine("Enter withdrawal amount:");
//    int withdraw = int.Parse(Console.ReadLine()!);

//    if (withdraw > balance)
//    {
//        throw new Exception("Insufficient balance!");
//    }
//    else
//    {
//        int bal = balance - withdraw;
//        Console.WriteLine($"Maintaining Balance: {bal}");
//    }


//}
//catch (FormatException)
//{
//    Console.WriteLine("Invalid format please enter a number!");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Thank you for using our ATM!");
//}


#endregion

#region --Day 15 FINAL BOSS — ATM--
//Now let's see if you can build this without me giving you the structure.

int balance = 1000;
Console.WriteLine("Welcome to Virtual ATM!");
bool validInput = false;

while (!validInput)
{
    try
    {

        Console.WriteLine("Enter withdrawal amount: ");


        int withdraw = int.Parse(Console.ReadLine()!);

        if (withdraw <= 0)
        {
            throw new Exception("Withdrawal must be greater than 0.");
        }
        if (withdraw > balance)
        {
            throw new Exception("Insufficient Balance!");
        }

        validInput = true;
        int bal = balance - withdraw;
        Console.WriteLine($"Remaining Balance: {bal}");


    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid format, please enter a number.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}
        Console.WriteLine("Thank you for using Virtual ATM!");

#endregion















#region ----

#endregion


#region ----

#endregion


#region ----

#endregion


#region ----

#endregion


#region ----

#endregion


#region ----

#endregion


#region ----

#endregion


#region ----

#endregion