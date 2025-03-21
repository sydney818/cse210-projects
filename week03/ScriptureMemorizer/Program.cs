using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
// Added randome list of scriptires
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), 
                "For God so loved the world, that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6), 
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."),

            new Scripture(new Reference("Psalm", 23, 1), 
                "The Lord is my shepherd; I shall not want.")
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];


        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(2);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
    //Added and end program script in a green color 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAll words are hidden. Program ending.");
                Console.ResetColor();
                break;
            }
        }

        Console.WriteLine("\nThank you for using the Scripture Memorization Program!");
    }
}