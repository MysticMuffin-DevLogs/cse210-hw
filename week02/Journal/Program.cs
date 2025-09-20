using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
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
                    //I am storing the prompt in a value
                    string prompt = generator.PromptUser();
                    //this displays the prompt to the user
                    Console.WriteLine(prompt);
                    //I am now sroring the response so i can later create the entry
                    string userResponse = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._todaysDate = DateTime.Now.ToShortDateString();
                    newEntry._prompt = prompt;
                    newEntry._response = userResponse;


                    myJournal.AddEntry(newEntry);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Enter a file name dont forget to include .txt");
                    string fileName = Console. ReadLine();
                    myJournal.SaveEntry(fileName);
                    break;
                case "4":
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    if (!loadFileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        loadFileName += ".txt";
                    }

                    myJournal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded.");
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