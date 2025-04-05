


using System;
using System.Threading;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", 
        "This activity will help you reflect on the good things in your life by having you list as many as you can in a certain area.")
    {
    }

    public void Run()
    {
        StartMessage();
        Random rnd = new Random();
        Console.WriteLine("\n" + prompts[rnd.Next(prompts.Length)]);
        Console.WriteLine("\nStart listing in:");
        Countdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndMessage();
    }
}