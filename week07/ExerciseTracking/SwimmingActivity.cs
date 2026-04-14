public class SwimmingActivity : Activity
{
    private int _swimmingLaps;
    public SwimmingActivity(float lengthInMin, int laps = 1) : base(lengthInMin)
    {
        _type = "Swimming";
        _swimmingLaps = laps;
    }

    public override float GetDistance()
    {
        return ((float)_swimmingLaps * 50f) / 1000f;
    }
    public override float GetSpeed()
    {
        return ((float)GetDistance() / (float)_lengthInMin) * 60f;
    }
    public override float GetPace()
    {
        return (float)_lengthInMin / (float)GetDistance();
    }
}