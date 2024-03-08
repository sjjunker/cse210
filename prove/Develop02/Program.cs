using System;
using System.Net.Quic;
//TODO: Creativity Section (maybe save and load from JSON)
//Maybe add a time and time between last entry
class Program
{
    static void Main(string[] args)
    {
        const int QUIT = 5;
        string userResponse = "";
        Menu newMenu = new Menu();
        Journal newJournal = new Journal();
        PromptGenerator newPromptGen = new PromptGenerator();

        //Begin Program
        Console.WriteLine("Welcome to Journal Prompt!");

        //Display the Menu Until User Selects Quit
        do
        {
            newMenu.Display();
            newMenu.GetSelection();
            Console.WriteLine();

            //Respond to the user's choice
            switch(newMenu._selection)
            {
                //Add
                case 1:
                    //Get user response from a random prompt
                    string currentPrompt = newPromptGen.GetPrompt();
                    Console.WriteLine(currentPrompt);
                    userResponse = Console.ReadLine();

                    //Get current date
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    //Create new entry
                    Entry newEntry = new Entry();
                    newEntry._prompt = currentPrompt;
                    newEntry._response = userResponse;
                    newEntry._date = dateText;

                    //Add to the journal
                    newJournal.AddEntry(newEntry);

                    break;
                //Save
                case 2:
                    //Get the fileName
                    Console.WriteLine("Please enter a file to save to: ");
                    string saveFileName = Console.ReadLine();

                    //Save to file
                    newJournal.SaveToFile(saveFileName);
                    Console.WriteLine($"File saved to {saveFileName}");

                    break;
                //Load
                case 3:
                    //Get file name
                    Console.WriteLine("Please enter a file to load: ");
                    string loadFileName = Console.ReadLine();

                    //Load from file
                    newJournal.LoadFromFile(loadFileName);
                    Console.WriteLine($"File loaded from {loadFileName}");

                    break;
                //Display
                case 4:
                    newJournal.DisplayAll();

                    break;
                default:
                    break;
            }

            Console.WriteLine();

        } while(newMenu._selection != QUIT);
    }
}