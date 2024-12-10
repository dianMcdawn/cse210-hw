public class GoalSimple : Goal
{
    private bool _isComplete;
    private DateOnly _dateStart;
    private DateOnly _dateComplete;
    private GoalEvent _event;

    //constructor
    public GoalSimple(string name, string description, int point, string difficulty, bool isComplete, DateOnly date) : base(name, description, point, difficulty)
    {
        _isComplete = isComplete;
        _dateStart = date;
    }
    //Getters
    public override string GetRepresentation()
    {
        IsComplete();
        string typeGoal = "Simple Goal";
        if (_isComplete == false)
        {
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | State: Not Completed";
        }
        else
        {
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | State: Completed on {_dateComplete}";
        }
    }

    //Mehtods
    public override void RecordEvent()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        _event = new GoalEvent(today);
        _dateComplete = today;
    }
    public override void IsComplete()
    {
        if (_event != null) { _isComplete = true; }
        else { _isComplete = false; }
    }
}