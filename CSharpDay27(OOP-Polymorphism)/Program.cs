namespace CSharpDay27_OOP_Polymorphism_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("John", "123", 150, 500);
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Eren", "456", 80);
            Freelancer freeLancer = new Freelancer("Levi", "X1Z", 150, 100, 5);

            employees.Add(fullTimeEmployee);
            employees.Add(partTimeEmployee);
            employees.Add(freeLancer);

            foreach (var e in employees)
            {
                e.ShowPayslip();
            }
        }
    }
}
