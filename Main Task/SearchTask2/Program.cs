namespace SearchTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsToCheck = new List<string>();
            Console.WriteLine($"Enter Words without Vowels or CTRL+Z to Quit:");
            string input;
            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    if (input == null)
                    {
                        break;
                    }
                    else if (input =="")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Empty Input");
                        Console.ResetColor();
                        continue;
                    }
                    if (CheckForVowels(input))
                    {
                        throw new NoVowels(input);
                    }
                    wordsToCheck.Add(input);
                }
                catch (NoVowels e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor= ConsoleColor.Green;
            foreach (var item in wordsToCheck)
            {
                Console.WriteLine($"\"{item}\" ");
            }
            Console.WriteLine($"No words without Vowels!");
            Console.ResetColor();
        }

        //The Method
        public static bool CheckForVowels(string input)
        {
            if (!input.ToLower().Contains('a') && !input.ToLower().Contains('e') && !input.ToLower().Contains('i')
                && !input.ToLower().Contains('o') && !input.ToLower().Contains('u'))
            {
                    throw new NoVowels(input);
            }
            return false;
        }
    }
}
