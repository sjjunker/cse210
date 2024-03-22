public class ListingActivity: Activity 
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        LoadPromptsFromFile("Prompts.txt");
    }

    //Load prompts
    private void LoadPromptsFromFile(string fileName)
    {
        //Make sure _prompts is empty
        _prompts.Clear();

        //Load the file
        string[] lines = System.IO.File.ReadAllLines(fileName);

        //Add each line to the _prompts list
        foreach(string line in lines) {
            _prompts.Add(line);
        }
    }

    //Run the activity
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowCountDown(5);

        //Begin Activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> userInput = new List<string>();

        while(DateTime.Now < endTime)
        {
            userInput = GetListFromUser();
        }

        //display count
        _count = userInput.Count;
        Console.WriteLine($"Youu entered {_count} items.");
        
        DisplayEndingMessage();
    }

    //Get a random prompt
    private void GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);

        Console.WriteLine(_prompts[randomNumber]);
    }

    //Get the user's list
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        string response = "";

        Console.WriteLine("Please list your items: ");
        do
        {
            response = Console.ReadLine();
            responses.Add(response);
        } while(response != "");

        return responses;
    }
}