public abstract class Activity
{
    protected DateTime _date = DateTime.Now;
    protected float _lengthInMin;
    protected string _type = "???";
    public Activity(float lengthInMin)
    {
        _lengthInMin = lengthInMin;
    }

    //In addition, the base class should declare (but not implement) methods for getting:
    // distance, 
    // speed, 
    // pace. 

    // These methods should be overridden in the derived classes.

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

//  GetSummary method to produce a string with all the summary information.

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_type} ({_lengthInMin.ToString("F1")} Min): Distance {GetDistance().ToString("F2")} km, Speed: {GetSpeed().ToString("F2")} kph, Pace: {GetPace().ToString("F2")} min per km";
    }
}