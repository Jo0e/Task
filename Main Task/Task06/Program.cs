namespace Task06
{
    internal class Program
    {
        // I had Sometime so i made this Main Function with the help of AI // 
        static void Main(string[] args)
        {
            // Create a Person object
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n-Display Person Details");
            Console.ForegroundColor= ConsoleColor.White;
            Person person1 = new Person("Alice", 30, "123 Main St", "USA");
            Console.WriteLine(person1.Display());
            Console.WriteLine($"__________________________________________________________");


            // Create a Student object
            Console.ForegroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine("\n-Display Student Details");
            Console.ForegroundColor = ConsoleColor.White;
            Student student1 = new Student("Bob", 22, "456 College Ave", "Canada", "Undergraduate", "Computer Science", 3.8);
            Console.WriteLine(student1.Display());
            Console.WriteLine($"__________________________________________________________");

            // Create a SalariedEmployee object
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n-Display Salaried Employee Details");
            Console.ForegroundColor = ConsoleColor.White;
            SalariedEmployee employee1 = new SalariedEmployee("Charlie", 35, "789 Office Rd", "UK", 50000, "Manager", "IT", 40, 1000, 500);
            Console.WriteLine(employee1.Display());
            Console.WriteLine($"__________________________________________________________");

            // Create an HourlyEmployee object
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n-Display Hourly Employee Details");
            Console.ForegroundColor = ConsoleColor.White;
            HourlyEmployee employee2 = new HourlyEmployee("David", 28, "101 Factory St", "Australia", 25, "Worker", "Production", 35, 15);
            Console.WriteLine(employee2.Display());
            Console.WriteLine($"__________________________________________________________");

            Console.WriteLine();
        }

    }
}
