using System;

class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        //Added welcome message//
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Set goals. Earn points. Level up your life!");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();



        string choice = "";
        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"Score: {goalManager.GetScore()}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5️. Load Goals");

            Console.WriteLine("6️.  ❌ Quit");

            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                goalManager.DisplayGoals();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                goalManager.SaveToFile(saveFile);
                Console.WriteLine("Saved! Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                goalManager.LoadFromFile(loadFile);

                goalManager.DisplayGoals();

                Console.WriteLine($"\nCurrent Score: {goalManager.GetScore()}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Console.ReadLine();
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nGoal Types: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("How many points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goalManager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            goalManager.AddGoal(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Target completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            goalManager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    static void RecordEvent()
    {
        goalManager.DisplayGoals();
        Console.Write("\nWhich goal did you complete? (Enter number): ");
        int index = int.Parse(Console.ReadLine()) - 1;
        goalManager.RecordEvent(index);
        Console.WriteLine("Event recorded. Press Enter to continue...");
        Console.ReadLine();
    }
}

