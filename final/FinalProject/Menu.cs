using System.Collections;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

public class Menu
{
    const int _QUIT = 6;
    int _userMenuChoice = 0;
    Plot newPlot;

    public Menu()
    {
        newPlot = new Plot();
    }

    //Display the menu while the user does not select quit
    public void DisplayMenu()
    {
        while (_userMenuChoice != _QUIT)
        {
            Console.WriteLine("\nPlease select from the menu (enter 1-6): \n");
            Console.WriteLine("1 - Create New Garden");
            Console.WriteLine("2 - Add Plant");
            Console.WriteLine("3 - Remove Plant");
            Console.WriteLine("4 - Save to File");
            Console.WriteLine("5 - Open from File");
            Console.WriteLine("6 - Quit");

            _userMenuChoice = int.Parse(Console.ReadLine());
            PerformSelection(_userMenuChoice);
        }
    }

    //Perform according to usesr selection
    public void PerformSelection(int userSelection)
    {
        switch (userSelection)
        {
            case 1: //Choose plot length

                Console.WriteLine("\nHow many rows would you like in your garden?");
                int plotSize = int.Parse(Console.ReadLine());
                newPlot.SetPlotLength(plotSize);
                Console.WriteLine($"\nYour plot is 4 feet wide and {newPlot.GetPlotLength()} feet long.");

                break;

            case 2: //Add a plant

                Console.WriteLine("\nWhat is your plant's name?");
                string name = Console.ReadLine();

                Console.WriteLine("Please give a brief description");
                string description = Console.ReadLine();

                Console.WriteLine("Is it an annual or a perennial?");
                string type = Console.ReadLine();

                if (type.ToLower() == "annual") //Create new annual
                {
                    Console.WriteLine("What season is it planted in?");
                    string plantingSeason = Console.ReadLine();

                    Console.WriteLine("How many days until it can be harvested?");
                    int daysToHarvest = int.Parse(Console.ReadLine());

                    Annual newAnnual = new Annual(plantingSeason, daysToHarvest, name, description);

                    newPlot.AddPlant(newAnnual);
                } else //create new perennial
                {
                    Console.WriteLine("What season is it harvested in?");
                    string harvestSeason = Console.ReadLine();

                    Console.WriteLine("How many years can it be harvested?");
                    int yearLifeSpan = int.Parse(Console.ReadLine());

                    Perennial newPerennial = new Perennial(name, description, harvestSeason, yearLifeSpan);

                    newPlot.AddPlant(newPerennial);
                }

                break;
            case 3: //Remove plant

                Console.WriteLine("\nWhat is the name of the plant you wish to remove?");
                string plantName = Console.ReadLine();
                newPlot.RemovePlant(plantName);

                break;

            case 4: //save
                Save newSave = new Save();
                newSave.SavePlot(newPlot.GetPlants());

                break;

            case 5: //load

                Open newOpen = new Open();
                newPlot.SetPlants(newOpen.OpenPlants());
                newPlot.DisplayPlot();

                break;

            case 6: //quit

                _userMenuChoice = _QUIT;
                break;
        }
    }  
}