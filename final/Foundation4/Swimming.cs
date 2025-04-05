public class Swimming : Activity
{
    private int _numOfLaps;
    private double _lapLengthInMeters = 50;
    public Swimming(int numOfLaps, int activityTimeInMinutes, string date) : base( activityTimeInMinutes, date)
    {
        _numOfLaps = numOfLaps;
    }
    public override string getActivityName()
    {
        return "Swimming";
    }
    public override double getDistance()
    {
        return Math.Round(((_numOfLaps * _lapLengthInMeters) / 1000) * 0.62, 2);
    }

    public override double getSpeed()
    {
        return (getDistance() / _activityTimeInMinutes) * _MPH;  
    }
    public override double getPace()
    {
        return Math.Round(_MPH / getSpeed(), 1);
    }
    
}