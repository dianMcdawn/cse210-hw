public class GoalCheck : Goal
{
    private bool _isComplete;
    private int _goalToAchieve;
    private int _lesserPoints;
    private DateOnly _date;
    private List<GoalEvent> _events = new List<GoalEvent>();

    //constructor
    public GoalCheck(string name, string description, int point, string difficulty, int goalToAchieve, int lesserPoints, bool isComplete, DateOnly date) : base(name, description, point, difficulty)
    {
        _isComplete = isComplete;
        _goalToAchieve = goalToAchieve;
        _lesserPoints = lesserPoints;
        _date = date;
    }
    //Getters
    public override string GetRepresentation()
    {
        if (_isComplete == false)
        {
            return $"{base.GetName()} Complete State: {_isComplete}";
        }
        else
        {
            return $"{base.GetName()} Complete State: {_isComplete} on {_date}";
        }
    }
    //Methods
    public override void RecordEvent() {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        GoalEvent evento = new GoalEvent(today);
        _events.Add(evento);
    }

}