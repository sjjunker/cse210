using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        const int QUIT = 4;
        int menuChoice = 0;

        do 
        {
            //Output the menu
            Console.WriteLine("\nWelcome to the Mindfulness Program\n");
            Console.WriteLine("Please choose from the following:");
            Console.WriteLine("1 - Breathing Activity");
            Console.WriteLine("2 - Reflection Activity");
            Console.WriteLine("3 - Listing Activity");
            Console.WriteLine("4 - Quit");

            //Get the user's menu choice
            try 
            {
                menuChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("User choice failure. Exiting program.\n");
                menuChoice = 4;
            }

        } while(menuChoice != QUIT);
    }
}