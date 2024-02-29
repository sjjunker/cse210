using System;

class Program
{
    static void Main(string[] args)
    {
        //Get first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Get last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //Print out James Bond style
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}