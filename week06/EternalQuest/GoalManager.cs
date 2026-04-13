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
                
            }
            if (_player == "4")
            {
                
            }
            if (_player == "5")
            {
                RecordEvent();
            }
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
            if (target is CheckListGoal checklistTarget)
            {
                if (checklistTarget.IsComplete())
                {
                    _score += checklistTarget.GetBonus();            
                }
            }
        }
        else
        {
            Console.WriteLine("This goal was already reported! (X o X)!");
        }
    }
}