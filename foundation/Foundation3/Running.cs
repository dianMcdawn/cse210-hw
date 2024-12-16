public class Running : Activity
{
    private double _distance;

    //Constructor
    public Running(string title, DateTime date, int duration, double distance) : base(title, date, duration)
    {
        _distance = distance;
    }

    //Getters
    public override double GetDistante(){
        return _distance;
    }
    public override double GetSpeed(){
        return ( _distance / base.GetDuration() ) * 60;
    }
    public override double GetPace(){
        return  base.GetDuration() / _distance;
    }

    //Method
}