using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunningProject = true;

        while (keepRunningProject)
        {
            Console.WriteLine("1. Write Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit Program");
            Console.Write("Choose an option: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    PromptGenerator generator = new PromptGenerator();
                    generator.PromptUser();
                    break;
                case "2":
                    Console.WriteLine("You selected 2");
                    break;
                case "3":
                    Console.WriteLine("You selected 3");
                    break;
                case "4":
                    Console.WriteLine("You selected 4");
                    break;
                case "5":
                    keepRunningProject = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
        }
    }
}