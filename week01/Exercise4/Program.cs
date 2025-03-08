using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter a list of numbers, type 0 to quit. ");

            string input = Console.ReadLine();
            userInput = int.Parse(input);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");
       
    }

}