public class RunningActivity : Activity
{
    private float _distance;
    public RunningActivity(float lengthInMin, float distance) : base(lengthInMin)
    {
        _type = "Running";
        _distance = distance;
    }

    public override float GetDistance()
    {
        return (float)_distance;
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