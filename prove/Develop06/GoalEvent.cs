public class GoalEvent
{
    private DateTime _date;

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public GoalEvent(DateTime date)
    {
        _date = date;
    }
    //***************************************
    //                GETTERS
    //***************************************
    public DateTime GetDate()
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