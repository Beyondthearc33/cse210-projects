public abstract class Activity
{
    protected int _activityTimeInMinutes;
    protected string _date;
    protected double _MPH = 60;
    public Activity(int activityTimeInMinutes, string date)
    {
        _activityTimeInMinutes = activityTimeInMinutes;
        _date = date;
    }
    public abstract string getActivityName();
    public abstract double getDistance();

    public abstract double getSpeed();
    public abstract double getPace();

    public string getSummary()
    {
        return $"{_date} {getActivityName()} ({_activityTimeInMinutes} min)- Distance: {getDistance()} miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile";
    }
    
}