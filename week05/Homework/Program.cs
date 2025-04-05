using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment math1 = new Assignment("Osborn", "Addition and Subtraction");
        Console.WriteLine(math1.GetSummary());

        MathAssignment math2 = new MathAssignment("Janet Brown", "Math", "5.3", "1-10");
        Console.WriteLine(math2.GetSummary());
        Console.WriteLine(math2.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("May Maryweather", "History", "The Causes of World II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}