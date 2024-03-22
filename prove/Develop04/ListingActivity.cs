public class ListingActivity: Activity 
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are some healthy foods you ate this week?");
        _prompts.Add("What are some things you learned this year?");
        _prompts.Add("Who have you spoken kind words to this month?");
    }

    //Run the activity
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowCountDown(5);

        //Begin Activity
        List<string> userInput = new List<string>();
        userInput = GetListFromUser();

        //display count
        _count = userInput.Count;
        Console.WriteLine($"You entered {_count} items.");
        
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
    private List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = new List<string>();

        Console.WriteLine("Please list your items: ");
        do
        {
            string response = Console.ReadLine();
            responses.Add(response);
        } while(DateTime.Now < endTime);

        return responses;
    }
}