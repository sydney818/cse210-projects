using System;
using System.Threading;

class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name} Activity!\n");
        Console.WriteLine(description);
        Console.Write("\nHow many seconds would you like to do this activity? ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to begin...");
        Dots(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        Dots(2);
        Console.WriteLine($"You completed the {name} Activity for {duration} seconds.");
    }

    public void Dots(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write("\r   \r"); 
        }
        Console.WriteLine();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}