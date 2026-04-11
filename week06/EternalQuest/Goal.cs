using System.Runtime.InteropServices.Java;

public abstract class Goal
{
    protected string _shortName, _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string cMark = "[ ]";
        if (IsComplete())
        {
            cMark = "[X]";
        }
        return $"{cMark} {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}