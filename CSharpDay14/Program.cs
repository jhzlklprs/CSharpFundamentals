//CSharpFundamentals — Day 14: Events

#region --Sample--
//class Program
//{
//    static void Main()
//    {
//        Door door = new Door();

//        door.DoorOpened += HandleDoorOpened;

//        door.Open();
//    }

//    static void HandleDoorOpened(object? sender, EventArgs e)
//    {
//        Console.WriteLine("The door was opened!");
//    }

//    class Door
//    {
//        public event EventHandler? DoorOpened;

//        public void Open()
//        {
//            Console.WriteLine("Opening door...");

//            DoorOpened?.Invoke(this, EventArgs.Empty);
//        }
//    }
//}
#endregion



#region --Day 14 — Mini Challenge 1--

using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Checking += StudentPassed;

        student.Pass();
    }

    static void StudentPassed(object? sender, EventArgs e)
    {
        Console.WriteLine("Student passed!");
    }

    class Student
    {
        public event EventHandler? Checking;

        public void Pass()
        {
            Console.WriteLine("Checking...");

            Checking?.Invoke(this, EventArgs.Empty);
        }
    }
}

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