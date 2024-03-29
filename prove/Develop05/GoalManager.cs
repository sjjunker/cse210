using System.Data;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private List<Levels> _levels;

    //Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _levels = new List<Levels>();

        //Create levels
        Levels newLevel1 = new Levels("Minnow", 0);
        _levels.Add(newLevel1);
        Levels newLevel2 = new Levels("Catfish Bait", 10);
        _levels.Add(newLevel2);
        Levels newLevel3 = new Levels("Painted Turtle", 50);
        _levels.Add(newLevel3);
        Levels newLevel4 = new Levels("Sunbathing Alligator", 150);
        _levels.Add(newLevel4);
        Levels newLevel5 = new Levels("Crocodile Hunter", 500);
        _levels.Add(newLevel5);
    }

    //Methods
    public void Start()
    {
        int menuChoice = 0;
        do
        {
            //Menu
            Console.WriteLine("Welcome To Eternal Quest");
            Console.WriteLine("Please choose from the following options");
            Console.WriteLine("1 - Create New Goal");
            Console.WriteLine("2 - List Goals");
            Console.WriteLine("3 - Save Goals");
            Console.WriteLine("4 - Load Goals");
            Console.WriteLine("5 - Record Event");
            Console.WriteLine("6 - Quit");
            Console.WriteLine($"Your current score is {_score}");
            Console.WriteLine($"Level: {DetermineLevel(_score)}");

            menuChoice = int.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    //Create a goal
                    CreateGoal();
                    break;
                case 2:
                    //Display the list of goals
                    ListGoalDetails();
                    break;
                case 3:
                    //Save the goals
                    SaveGoals();
                    break;
                case 4:
                    //Load goals
                    LoadGoals();
                    break;
                case 5:
                    //Record Event
                    RecordEvent();
                    break;
                case 6:
                    //Quit the program
                    System.Environment.Exit(1);
                    break;
            }
        } while (menuChoice != 6);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }
    public void ListGoalNames()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        foreach(Goal goal in _goals)
        {
            string details = goal.GetDetailsString();
            Console.WriteLine(details);
        }
    }
    public void CreateGoal()
    {
        //Goal type choice
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1 - Simple Goal");
        Console.WriteLine("2 - Eternal Goal");
        Console.WriteLine("3 - Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        int goalChoice = int.Parse(Console.ReadLine());

        switch (goalChoice)
                    {
                        case 1:
                            //Get input
                            Console.WriteLine("What is the name of your goal?");
                            string name = Console.ReadLine();
                            Console.WriteLine("What is a short description of it?");
                            string description = Console.ReadLine();
                            Console.WriteLine("How many points is it worth?");
                            int points = int.Parse(Console.ReadLine());
                            
                            //Create a simple goal
                            SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points);
                            _goals.Add(newSimpleGoal);

                            break;
                        case 2:
                            //Get input
                            Console.WriteLine("What is the name of your goal?");
                            name = Console.ReadLine();
                            Console.WriteLine("What is a short description of it?");
                            description = Console.ReadLine();
                            Console.WriteLine("How many points is it worth?");
                            points = int.Parse(Console.ReadLine());

                            //Create an eternal goal
                            EternalGoal newEternalGoal = new EternalGoal(name, description, points);
                            _goals.Add(newEternalGoal);

                            break;
                        case 3:
                            //Get input
                            Console.WriteLine("What is the name of your goal?");
                            name = Console.ReadLine();
                            Console.WriteLine("What is a short description of it?");
                            description = Console.ReadLine();
                            Console.WriteLine("How many points is it worth?");
                            points = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many times will you repeat it?");
                            int target = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is the completion bonus?");
                            int bonus = int.Parse(Console.ReadLine());

                            //Create a checklist goal
                            CheckListGoal newCheckListGoal = new CheckListGoal(name, description, points, target, bonus);
                            _goals.Add(newCheckListGoal);

                            break;
                    }
    }
    public void RecordEvent()
    {
        //Choose the goal to change
        Console.WriteLine("The goals are:");
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            string name = goal.GetName();
            Console.WriteLine($"{counter} - {name}");
            counter++;
        }

        Console.WriteLine("Which goal did you accomplish?");
        int eventChoice = int.Parse(Console.ReadLine());

        int points = _goals[eventChoice - 1].RecordEvent();
        Console.WriteLine($"Congratulations! You earned {points}!");
        _score += points;
    }
    public void SaveGoals()
    {
        Console.WriteLine("Please enter a file name: ");
                    string fileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goal goal in _goals) 
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                        outputFile.WriteLine(_score);
                    }
    }
    public void LoadGoals()
    {
        //Empty current _goal list
        _goals.Clear();

        Console.WriteLine("Please enter a file name:");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal newSimpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    newSimpleGoal.RecordEvent();
                }
                _goals.Add(newSimpleGoal);
            } else if (parts[0] == "EternalGoal")
            {
                EternalGoal newEternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(newEternalGoal);
            } else if (parts[0] == "CheckListGoal")
            {
                CheckListGoal newCheckListGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                newCheckListGoal.SetAmountCompleted(int.Parse(parts[6]));
                _goals.Add(newCheckListGoal);
            } else 
            {
                _score = int.Parse(parts[0]);
            }
        }
    }
    public string DetermineLevel(int score) 
    {
        string currentLevel = "";

        foreach(Levels level in _levels)
        {
            if (score >= level.GetPointsRequired())
            {
                currentLevel = level.GetName();
            }
        }
        
        return currentLevel;
    }
}
