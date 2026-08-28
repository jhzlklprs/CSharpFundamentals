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

#region --Day 14 — Mini Challenge Student--

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student();

//        student.Checking += StudentPassed;
//        student.Checking += StudentNotification;
//        student.Checking -= StudentNotification;
//        student.Pass();
//    }

//    static void StudentPassed(object? sender, EventArgs e)
//    {
//        Console.WriteLine("Student passed!");
//    }

//    static void StudentNotification (object? send, EventArgs e)
//    {
//        Console.WriteLine($"Notification: Student passed!");
//    }

//    class Student
//    {
//        public event EventHandler? Checking;

//        public void Pass()
//        {
//            Console.WriteLine("Checking...");

//            Checking?.Invoke(this, EventArgs.Empty);
//        }
//    }
//}


#endregion

#region --Mini Challenge 1 — Door Opened--

//class Program
//{
//    static void Main()
//    {
//        Door door = new Door();

//        door.DoorOpened += DoorOpenedMessage;
//        door.DoorOpened += SecurityCheck;
//        door.DoorOpened -= SecurityCheck;
//        door.Open();


//    }

//    static void SecurityCheck(Object? sender, EventArgs e)
//    {
//        Console.WriteLine("Security check started!");
//    }

//    static void DoorOpenedMessage(Object? sender, EventArgs e)
//    {
//        Console.WriteLine("Door opened!");
//    }



//    class Door
//    {
//        public event EventHandler? DoorOpened;

//        public void Open()
//        {
//            Console.WriteLine("Door is opening...");
//            DoorOpened?.Invoke(this, EventArgs.Empty);
//        }
//    }
//}


#endregion

#region --Mini Challenge 4 — Temperature Alert 🌡️--

//class Program
//{
//    static void Main()
//    {
//        TemperatureSensor sensor = new TemperatureSensor();

//        sensor.TemperatureChanged += TemperatureAlert;
//        sensor.ChangeTemperature(35);
//    }


//    static void TemperatureAlert(Object? sender, EventArgs e)
//    {
//        Console.WriteLine("Temperature changed!");
//    }

//    class TemperatureSensor
//    {
//        public event EventHandler? TemperatureChanged;

//        public void ChangeTemperature(int temperature)
//        {
//            Console.WriteLine("Temperature changing...");
//            TemperatureChanged?.Invoke(this, EventArgs.Empty);
//        }


//    }
//}
#endregion

#region --Mini Boss Fight — Student System--

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student();

//        //student.StudentPassed += PassAlert;
//        //student.Pass();
//        student.StudentFailed += FailAlert;
//        student.Fail();

//    }

//    static void PassAlert(Object? sender, EventArgs e)
//    {

//        Console.WriteLine("Congratulations notification sent!");
//    }

//    static void FailAlert(Object? sender, EventArgs e)
//    {

//        Console.WriteLine("Please study harder!");
//    }

//    class Student
//    {
//        public event EventHandler? StudentPassed;
//        public event EventHandler? StudentFailed;

//        public void Pass()
//        {
//            Console.WriteLine("Student passed!");
//            StudentPassed?.Invoke(this, EventArgs.Empty);
//        }

//        public void Fail()
//        {
//            Console.WriteLine("Student failed!");
//            StudentFailed?.Invoke(this, EventArgs.Empty);
//        }
//    }
//}


#endregion

#region --Final Day 14 Exercise — Bank Account--

class Program
{
    static void Main()
    {
        BankAccount bankaccount = new BankAccount();
        bankaccount.MoneyDeposited += DepositAlert;
        bankaccount.Deposit(500);

    }

    static void DepositAlert(Object? sender, EventArgs e)
    {
        Console.WriteLine($"Deposit notification sent!");
    }


    class BankAccount
    {
        public event EventHandler? MoneyDeposited;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Money deposited: {amount}");
            MoneyDeposited?.Invoke(this, EventArgs.Empty);
        }
    }
}

#endregion
