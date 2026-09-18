//ENUMS

#region --Exercise: Traffic Light Simulator--

// Mission: Simulate a traffic light that cycles through states and tells the driver what to do.

// Requirements:

// Create an enum TrafficLight with values Red, Yellow, Green.
// Write a method string GetInstruction(TrafficLight light) that uses a switch to return:
// Red → "Stop"
// Yellow → "Slow down"
// Green → "Go"
// In Main, create a small loop that cycles through all three lights (in order: Red → Green → Yellow → Red) and prints the instruction for each.
// Ask the user to type a color ("Red", "Yellow", "Green") and use Enum.Parse to convert it, then print the instruction for what they typed. Handle invalid input gracefully (hint: Enum.TryParse is safer than Enum.Parse here — similar idea to TryGetValue vs ContainsKey+indexing from last time).

// class Program
// {
//     static void Main()
//     {


//     }



// }

#endregion



#region --Exercise: Optional Survey Field-- 
// Exercise: Optional Survey Field

// Mission: Simulate collecting an optional numeric answer from a user, where "blank" is a valid response.

// Requirements:

// Ask the user: "What's your age? (press Enter to skip)"
// Read the input with Console.ReadLine(). If the input is empty (""), store null into an int? age variable. Otherwise, parse it into age.
// Use HasValue to check the result:
// If it has a value, print "Your age is: {age}"
// If not, print "No age provided."
// Separately, create a displayAge variable using ?? that defaults to 0 if age is null, and print it.

class Program
{
    static void Main()
    {
        Console.WriteLine("What's your age? (press Enter to skip)");
        int? age = null;
        

        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            age = null;
        }
        else
        {
            age = int.Parse(input);
        }

        int displayAge = age ?? 0;

        Console.WriteLine(displayAge);
    }
}

#endregion

