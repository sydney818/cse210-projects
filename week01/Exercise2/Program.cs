using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }


        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
   
       

        if (letter == "A" && sign == "+")
        {
            sign = "";  
        }
        else if (letter == "F")
        {
            sign = "";  
        }

        Console.WriteLine ($"Your grade is a {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine ("Congratulations you passed the class!");
        }
        else 
        {
            Console.WriteLine ("You did not pass. Please keep trying!");
        }

    }
}