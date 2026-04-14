
public class CyclismActivity : Activity
{
    private float _speed;
    public CyclismActivity(float lengthInMin, float speed) : base(lengthInMin)
    {
        _type = "Cyclism";
        _speed = speed;
    }

    public override float GetSpeed()
    {
        return (float)_speed;
    }
    public override float GetDistance()
    {
        return ((float)GetSpeed() * (float)_lengthInMin) / 60f;
    }
    public override float GetPace()
    {
        return (float)_lengthInMin / (float)GetSpeed();
    }
}