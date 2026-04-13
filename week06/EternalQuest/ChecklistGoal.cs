public class CheckListGoal : Goal
{
    private int _amountCompleted, _target, _bonus;
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        GoalManager gm = new ();
        if (IsComplete())
        {
            Console.Write("You already achieved this goal.");
        }
        else
        {        
            _amountCompleted += 1;
        }
    }

    public override bool IsComplete()
    {
        if(_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        string cMark = "[ ]";
        if (IsComplete())
        {
            cMark = "[X]";
        }
        return $"{cMark} {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName}|{_description}|{_points}|{_bonus}|{_amountCompleted}|{_target}";
    }

    public int GetBonus()
    {
        return _bonus;
    }
}