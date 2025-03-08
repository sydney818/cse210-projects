using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = UserNameInput();
        int userNumber = UserNumberInput();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserNameInput()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumberInput()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}