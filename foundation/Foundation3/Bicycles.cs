public class Bicycles : Activity
{
    private double _speed;

    //Constructor
    public Bicycles(string title, DateTime date, int duration, double speed) : base(title, date, duration)
    {
        _speed = speed;
    }
    //Setters

    //Getters
    public override double GetDistante()
    {
        return _speed * GetDuration() / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    //Methods

}