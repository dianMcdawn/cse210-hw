public class GoalEvent
{
    private DateOnly _date;

    //Cosntructor
    public GoalEvent(DateOnly date)
    {
        _date = date;
    }
    //Getter
    public DateOnly GetDate()
    {
        return _date;
    }
    //Methods
    public string GetEventSummary()
    {
        return $"On {_date} was added this mark event";
    }
}