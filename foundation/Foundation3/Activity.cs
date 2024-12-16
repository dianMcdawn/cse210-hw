public abstract class Activity
{
    private string _title;
    private DateTime _date;
    private int _duration;

    //Constructor
    public Activity(string title, DateTime date, int duration)
    {
        _title = title;
        _date = date;
        _duration = duration;
    }

    //Setters

    //Getters
    public double GetDuration()
    {
        return _duration;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public abstract double GetDistante();
    public abstract double GetSpeed();
    public abstract double GetPace();

    //Methods
    public string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min)- Distance {GetDistante()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}