
using System;
class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What could you learn from this?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity() : base("Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        StartMessage();
        Random rnd = new Random();

        Console.WriteLine("\n" + prompts[rnd.Next(prompts.Length)]);
        Dots(5);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("\n" + questions[rnd.Next(questions.Length)]);
            Dots(5);
            elapsed += 5;
        }

        EndMessage();
    }
}