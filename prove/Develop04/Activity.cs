public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        //Begin starting meessage
        Console.WriteLine($"Welcome to the {_name}. {_description} Now, before beginning, please enter how long in seconds you would like to perform the activity:");

        //Get the duration
        try 
        {
            _duration = int.Parse(Console.ReadLine());
        }
        catch
        {
            try
            {
                Console.WriteLine("Invalid response. Please enter an integer value:");
                _duration = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input still invalid. Exiting program.");
                Environment.Exit(1);
            }
        }

        //Finish starting message and pause
        Console.WriteLine("Thank you for your input. Please, prepare to begin . . .");
        ShowCountDown(1000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("You just finished. Great job!");
        Thread.Sleep(3000);

        Console.WriteLine($"You completed the {_name} in {_duration}seconds.");
        Thread.Sleep(3000);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime) {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count) {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for(int count = 5; count > 0; count--)
        {
            Console.WriteLine(count);
            Thread.Sleep(seconds);
            Console.WriteLine("\b \b");
        }
    }
}