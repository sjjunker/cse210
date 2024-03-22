using System;
using System.Collections;
using System.Linq.Expressions;
/*Extra creativity:
--Used a try catch block to handle user input both in the 
  starting message in Activity base class
  and in Program.cs when getting the user's menu choice.
*/

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
            Console.WriteLine("2 - Reflecting Activity");
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

            //Run the appropriate menu choice
            switch(menuChoice)
            {
                case 1:
                    BreathingActivity newBreathingActivity = new BreathingActivity();
                    newBreathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity newReflectingActivity = new ReflectingActivity();
                    newReflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity newListingActivity = new ListingActivity();
                    newListingActivity.Run();
                    break;
                case 4:
                    Environment.Exit(1);
                    break;
            }

        } while(menuChoice != QUIT);
    }
}