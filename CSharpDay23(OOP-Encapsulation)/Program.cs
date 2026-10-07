namespace CSharpDay23_OOP_Encapsulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBank = new BankAccount("John Doe", "1234567890", 0);
            myBank.DisplayInfo();
            myBank.Deposit(999);
            myBank.Withdraw(-50);
        }


        class BankAccount
        {

            public string AccountHolder { get; set; }
            public string AccountNumber { get; set; }
            private decimal balance;
            public decimal Balance
            {
                get { return balance; }
            }

            private bool IsValidAmount(decimal amount)
            {
                return amount > 0;
            }

            public void Deposit(decimal amount)
            {
                if (IsValidAmount(amount))
                {
                    balance += amount;
                    Console.WriteLine($"Deposited {amount}, new balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount");
                }
            }

            public void Withdraw (decimal amount)
            {
                if (!IsValidAmount(amount))
                {
                    Console.WriteLine("Invalid withdrawal amount");
                }
                else if (balance < amount)
                {
                    Console.WriteLine("Insufficient Funds, please enter valid amount!");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew {amount}, new balance: {Balance}");
                }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Account Holder: {AccountHolder}");
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Balance: {Balance}");
            }


            public BankAccount (string accountHolder, string accountNumber, decimal balance)
            {
                AccountHolder = accountHolder;
                AccountNumber = accountNumber;
                this.balance = balance;
            }
        }
    }
}
