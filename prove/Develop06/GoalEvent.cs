public class GoalEvent
{
    private DateOnly _date;

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public GoalEvent(DateOnly date)
    {
        _date = date;
    }
    //***************************************
    //                GETTERS
    //***************************************
    public DateOnly GetDate()
    {
        return _date;
    }
    //***************************************
    //                METHODS
    //***************************************
    public string GetEventSummary()
    {
        return $"On {_date} was added this mark event";
    }
}