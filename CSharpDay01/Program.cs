

//CSharp Day 1
#region --Multiple Data Types--
//string name = "Kiel";
//int age = 25;
//decimal pawnAmount = 15000.00m;
//bool isActive = true;
//DateTime transactiondate = DateTime.Now;


//Console.WriteLine(name);
//Console.WriteLine(age);
//Console.WriteLine(pawnAmount);
//Console.WriteLine(isActive);
//Console.WriteLine(transactiondate);
#endregion

#region --String Variables--
//string firstname = "Kiel";
//string lastname = "Peras";

//string fullname = firstname + " " + lastname;

//Console.WriteLine(fullname);
#endregion

#region --String Interpolation--

//string name = "Kiel";
//int age = 25;

//Console.WriteLine($"Name: {name} \nAge: {age}");

//string customerName = "Juan";
//decimal principal = 10000.00m;
//decimal interest = 500.00m;
//decimal serviceCharge = 100.00m;

//decimal total = principal + interest + serviceCharge;

//Console.WriteLine($"Customer: {customerName}");
//Console.WriteLine($"Principal: {principal}");
//Console.WriteLine($"interest: {interest}");
//Console.WriteLine($"Service Charge: {serviceCharge}");
//Console.WriteLine($"Total: {total}");
#endregion



#region --Exercises--

////Exercise 1 - Personal Information
//string name = "Kiel";
//int age = 28;
//decimal height = 170m;
//bool isWorking = true;

//Console.WriteLine($"Name: {name}");
//Console.WriteLine($"Age: {age}");
//Console.WriteLine($"Height: {height}");
//Console.WriteLine($"Working: {isWorking}");

////Exercise 2 - Employee
//string eName = "Kiel";
//int eID = 2025011;
//decimal eSalary = 35000;
//bool isActive = true;

//Console.WriteLine($"Employee: {eName}");
//Console.WriteLine($"ID: {eID}");
//Console.WriteLine($"Salary: {eSalary}");
//Console.WriteLine($"Active: {isActive}");

////Exercise 3 - Pawn Transaction
//string customerName = "Kiel";
//decimal principal = 12m;
//decimal interest = 10m;
//decimal serviceCharge = 20m;

//decimal totalAmount = principal + interest + serviceCharge;

//Console.WriteLine($"Customer Name: {customerName}");
//Console.WriteLine($"Principal: {principal}");
//Console.WriteLine($"Interest: {interest}");
//Console.WriteLine($"Service Charge: {serviceCharge}");
//Console.WriteLine($"Total Amount: {totalAmount}");

//Create your own mini Pawn Transaction Summary
string refNumber = "PN-2026-001";
string customerName = "Kiel";
string itemDescription = "18k Gold Necklace";
decimal apprValue = 25000.00m;
decimal loanAmount = 15000.00m;
decimal interest = 750.00m;
decimal serviceCharge = 100.00m;

decimal totalCharge = interest + serviceCharge ;
decimal amountDue = loanAmount + totalCharge ;
DateTime transDate = DateTime.Now;

Console.WriteLine("=================================");
Console.WriteLine("PAWN TRANSACTION");
Console.WriteLine("=================================");
Console.WriteLine("\n");
Console.WriteLine($"Reference No : {refNumber}");
Console.WriteLine($"Customer : {customerName}");
Console.WriteLine($"Item : {itemDescription}");
Console.WriteLine("\n");
Console.WriteLine($"Appraised Value : {apprValue:N2}");
Console.WriteLine($"Loan Amount : {loanAmount:N2}");
Console.WriteLine($"Interest : {interest:N2}");
Console.WriteLine($"Service Charge : {serviceCharge}");
Console.WriteLine("\n");
Console.WriteLine($"Total Charges : {totalCharge:N2}");
Console.WriteLine($"Amount Due : {amountDue:N2}");
Console.WriteLine($"Transaction Date : {transDate}");
#endregion