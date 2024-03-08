public class Menu
{
    List<string> _menu = new List<string>();
    public int _selection;

    public Menu()
    {
        this._menu.Add("1. Start a New Entry");
        this._menu.Add("2. Save Journal");
        this._menu.Add("3. Load Journal");
        this._menu.Add("4. View Your Journal");
        this._menu.Add("5. Quit");
    }

    public void Display()
    {
        foreach (string item in _menu)
        {
            Console.WriteLine(item);
        }
    }

    public void GetSelection()
    {
        Console.WriteLine("Please Enter a Menu Choice (1-5): ");
        string userSelection = Console.ReadLine();
        this._selection = int.Parse(userSelection);
    }
}