using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();
        activity.Add(new Running("14 Apr 2025", 25, 2.8));
        activity.Add(new Cycling("10 Apr 2025", 40, 14.5));
        activity.Add(new Swimming("08 Apr 2025", 35, 28));
   
    foreach (Activity act in activity)
    {
        Console.WriteLine(act.GetSummary());
    }
  }
}