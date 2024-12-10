public class GoalSimple : Goal
{
    private bool _isComplete;
    private DateOnly _date;
    private GoalEvent _event;

    //constructor
    public GoalSimple(string name, string description, int point, string difficulty, bool isComplete, DateOnly date) : base(name, description, point, difficulty)
    {
        _isComplete = isComplete;
        _date = date;
    }
    //Getters
    public override string GetRepresentation()
    {
        if (_isComplete == false)
        {
            return $"{base.GetName().PadRight(15)} Complete State: {_isComplete}";
        }
        else
        {
            return $"{base.GetName().PadRight(15)} Complete State: {_isComplete} on {_date}";
        }
    }

    //Mehtods
    public override void RecordEvent()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        _event = new GoalEvent(today);
    }
    /*public void IsComplete() { }*/
}