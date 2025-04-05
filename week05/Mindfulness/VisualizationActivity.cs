using System;
using System.Threading;

//Added this to be creative
class VisualizationActivity : Activity
{

    private string[] scenes = {
        "Take a moment to read this... then close your eyes and imagine it.",
        "You imagine yourself walking through a peaceful forest...",
        "The sun warms your face and a soft breeze brushes your skin...",
        "You hear a gentle stream flowing nearby...",
        "With each breath, you feel more relaxed and grounded..."
    };

    public VisualizationActivity() : base("Visualization",
        "This activity will help you relax by guiding your imagination through a peaceful scene. Let your mind wander as you visualize calming settings and gentle sensations.")
    {
    }

    public void Run()
    {
        StartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n" + scenes[index]);
            Dots(4);
            index = (index + 1) % scenes.Length;
        }

        EndMessage();
    }

}



