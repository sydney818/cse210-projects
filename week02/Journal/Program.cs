using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to your journal program!");

        while (true)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1) Write Entry (Not sure what to write, let us give you questions.)");
            Console.WriteLine("2) Free Write");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Display Entries");
            Console.WriteLine("5) Save");
            Console.WriteLine("6) Quit");

            Console.WriteLine("Please select an option (1-6)");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = new PromptGenerator().GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");

                    Console.WriteLine("Please enter your response: ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    Console.WriteLine("Enter your journal entry:");
                    string freeResponse = Console.ReadLine();
                    string freeDate = DateTime.Now.ToString("yyyy-MM-dd");

                    Entry freeEntry = new Entry(freeDate, "Free Write", freeResponse);
                    journal.AddEntry(freeEntry);
                    break;

                //Display all entries 
                case "4":
                    journal.DisplayAll();
                    break;

                //Load previous entries 
                case "3":
                    Console.WriteLine("Enter the filename to load entries:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);  
                    break;

                case "5":
                    Console.WriteLine("Enter the filename to save entries:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);  
                    break;

                case "6":
                    Console.WriteLine("--- Exiting program --");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please select a new choice.");
                    break;
            }
        }
    }
}