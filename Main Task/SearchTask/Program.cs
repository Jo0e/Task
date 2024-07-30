namespace SearchTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intsToCheck =  new List<int>();
            string input;
            Console.WriteLine($"Pleas Enter numbers or CTRL+Z to Quit:");
            while (true)
            {
                try
                {
                    Console.Write($"_ ");
                    input = Console.ReadLine();
                    if (input == null)
                        break;

                    int temp = int.Parse(input);
                    if (intsToCheck.Contains(temp))
                    {
                        throw new DuplicatedNumbers(temp);
                    }
                    intsToCheck.Add(temp);
                }
                catch (DuplicatedNumbers ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Only Enter Numbers!!");
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in intsToCheck)
            {
                Console.WriteLine($"- {item} " );
            }
            Console.WriteLine($"No Duplicated Numbers Found");
            Console.ResetColor();
            
        }
    }
}
