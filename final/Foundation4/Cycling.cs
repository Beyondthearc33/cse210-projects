using System.Runtime.InteropServices;

public class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, int activityTimeInMinutes, string date) : base( activityTimeInMinutes, date)
    {
        _speed = speed;
    }
    public override string getActivityName()
    {
        return "Cycling";
    }
    public override double getDistance()
    {
        return (_activityTimeInMinutes / _MPH) * _speed;
    }
    public override double getSpeed()
    {
        return _speed;
    }
    public override double getPace()
    {
        return _MPH / _speed;
    }
}