public class Swimming : Activity
{
    private double _laps;

    //Constructors
    public Swimming(string title, DateTime date, int duration, double laps) : base(title, date, duration)
    {
        _laps = laps;
    }
    //Setters
    
    //Getters
    //Getters
    public override double GetDistante(){
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed(){
        return ( GetDistante() / base.GetDuration() ) * 60;
    }
    public override double GetPace(){
        return  base.GetDuration() / GetDistante();
    }

    //Methods
    
}