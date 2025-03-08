using System;

class Program
{
    static void Main(string[] args)
    {
        

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

       
       while (guess != number)
       {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

            if (guess < number)
            {
                Console.WriteLine("Higer");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
       }

        
       
    }
}