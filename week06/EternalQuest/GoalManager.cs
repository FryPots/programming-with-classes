using System.Globalization;
using System.Runtime;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private string _player;

    public GoalManager()
    {
        _goals = new ();
        _score = 0;
    }
    public void Start()
    {
        while (_player != "6")
        {   
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine($"Menu Options:");
            Console.WriteLine( "  1. Create New Goal");
            Console.WriteLine( "  2. List Goals");
            Console.WriteLine( "  3. Save Goals");
            Console.WriteLine( "  4. Load Goals");
            Console.WriteLine( "  5. Record Event");
            Console.WriteLine( "  6. Quit");
            Console.Write("Select a choice from the menu: ");
            _player = Console.ReadLine();

            if (_player == "1")
            {
                CreateGoal();
            }
            if (_player == "2")
            {
                Console.WriteLine("The goals are: ");
                ListGoalDetails();
            }
            if (_player == "3")
            {
                SaveFile();
            }
            if (_player == "4")
            {
                LoadFile();
            }
            if (_player == "5")
            {
                RecordEvent();
            }
        
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }


    }

    public void DisplayPlayerInfo()
    {
        
    }

    public void ListGoalNames()
    {
        int idx = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{idx} -- {goal.GetName()}");
            idx += 1;
        }
    }

    public void ListGoalDetails()
    {
        int idx = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{idx} -- {goal.GetDetailsString()}");
            idx += 1;
        }
    }

    public void CreateGoal()
    {   
        List<string> goalSet = new ();
        
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simples Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        goalSet.Add(Console.ReadLine());
        
        Console.Write("What is a short description of it? ");
        goalSet.Add(Console.ReadLine());

        Console.Write("What is the amount of points associated with this goal? ");
        goalSet.Add(Console.ReadLine());

        string goalName, goalDesc;
        int goalPts;

        goalName = goalSet[0];
        goalDesc = goalSet[1];
        goalPts  = int.Parse(goalSet[2]);

        if (goalType == "1")
        {
            SimpleGoal newGoal = new (goalName, goalDesc, goalPts);
            _goals.Add(newGoal);
        }

        if (goalType == "2")
        {
            EternalGoal newGoal = new (goalName, goalDesc, goalPts);
            _goals.Add(newGoal);
        }

        if (goalType == "3")
        {
            Console.Write("How many times foes this goal must need to be accomplished for a bonus? ");
            goalSet.Add(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            goalSet.Add(Console.ReadLine());

            int goalTarget, goalBonus;
            goalTarget = int.Parse(goalSet[3]);
            goalBonus  = int.Parse(goalSet[4]);


            CheckListGoal newGoal = new (goalName, goalDesc, goalPts, goalTarget, goalBonus);
            _goals.Add(newGoal);
        }

    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.WriteLine("\nWhich goal would you like to report? (type its number id) ");
        int idx = int.Parse(Console.ReadLine());
        Goal target = _goals[idx-1];
        target.RecordEvent();
        if (!target.IsComplete())
        {
            _score += target.GetPts();
            Console.WriteLine($"You have earned {target.GetPts()} points!");       
        }
        else
        {
            Console.WriteLine("This goal was already reported! (X o X)!");
        }
    }

    public void SaveFile()
    {
        Console.Clear();
        Console.WriteLine("What is the name of your .txt file? (exclude the file extension)");
        Console.Write("> ");

        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName + ".txt"))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("File saved successfully!");
        }
    public void LoadFile()
    {
        Console.Clear();
        Console.WriteLine("What is the name of your .txt file? (exclude the file extension)");
        Console.Write("> ");
        
        string fileName = Console.ReadLine();

        _goals = new List<Goal>();

        using (StreamReader reader = new StreamReader(fileName + ".txt"))
        {
            _score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                List<string> myObject = line.Split(":").ToList();
                List<string> myValues = myObject[1].Split("|").ToList();

                string name = myValues[0];
                string desc = myValues[1];
                int points = int.Parse(myValues[2]);

                if (myObject[0] == "SimpleGoal")
                {
                    SimpleGoal tmp = new SimpleGoal(name, desc, points);

                    bool completed = bool.Parse(myValues[3]);
                    if (completed)
                    {
                        tmp.RecordEvent();
                    }

                    _goals.Add(tmp);
                }
                if (myObject[0] == "CheckListGoal")
                {
                    int bonus = int.Parse(myValues[3]);
                    int amountCompleted = int.Parse(myValues[4]);
                    int target = int.Parse(myValues[5]);

                    CheckListGoal tmp = new CheckListGoal(name, desc, points, bonus, target);

                    for (int i = 0; i < amountCompleted; i++)
                    {
                        tmp.RecordEvent();
                    }

                    Console.WriteLine($"Target: {target}\nTimes Completed: {amountCompleted}");

                    _goals.Add(tmp);
                }
                if (myObject[0] == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, desc, points));
                }
            }
        }

        Console.WriteLine($"{_goals.Count} elements created!");
    }
}