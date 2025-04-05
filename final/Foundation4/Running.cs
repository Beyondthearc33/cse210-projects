using System.Dynamic;

public class Running : Activity
{
private double _distanceInMiles;

    public Running(double distanceInMiles, int activityTimeInMinutes, string date) : base( activityTimeInMinutes, date)
    {
        _distanceInMiles = distanceInMiles;
    }
    public override string getActivityName()
    {
        return "Running";
    }
    public override double getDistance()
    {
        return _distanceInMiles;
    }

    public override double getSpeed()
    {
        return (_distanceInMiles / _activityTimeInMinutes) * _MPH; 
    }
    public override double getPace()
    {
        return Math.Round(_activityTimeInMinutes / _distanceInMiles, 1);
    }
}