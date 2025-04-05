

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", 
        "Take a moment to relax as you focus on slow, deep breaths. This activity will guide you through calming breathing patterns to help clear your mind.")
    {
    }

    public void Run()
    {
        StartMessage();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breath in...");
            Countdown(5);
            Console.WriteLine("Breath out...");
            Countdown(5);
            elapsed +=8;

        }

        EndMessage();
    }
}