using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Get the grade percent and convert to float
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        float gradePercentage = float.Parse(userInput);

        //Determine the letter grade using if/else
        string letter;

        if (gradePercentage >= 90) 
        {
            letter = "A";
        }
        else if (gradePercentage >= 80) 
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60) 
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Determine the sign
        string sign;

        if (gradePercentage >= 97 || gradePercentage < 60)
        {
            sign = "";
        }
        else if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        //Print the letter grade
        Console.WriteLine($"Letter Grade: {letter}{sign}");

        //Determine if they passed
        if (gradePercentage >= 70) 
        {
            Console.WriteLine("Congratulations! You Passed.");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next time.");
        }
    }
}