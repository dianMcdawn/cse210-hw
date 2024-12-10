public class GoalEternal : Goal
{
    private string _periodGoal;
    private DateOnly _dateStart;
    private List<GoalEvent> _events = new List<GoalEvent>();

    //constructor
    public GoalEternal(string name, string description, int point, string difficulty, string periodGoal, bool isComplete, DateOnly date) : base(name, description, point, difficulty)
    {
        _periodGoal = periodGoal;
        _dateStart = date;
    }
    //Getters
    public override string GetRepresentation()
    {
        string typeGoal = "Eternal Goal";
        return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Tries: {_events.Count()} | Points : {GetScore()}";
    }
    public override string GetDetails()
    {
        string details = GetRepresentation() + "\n";
        foreach (GoalEvent evento in _events)
        {
            details = details + "\n" + evento.GetEventSummary();
        }
        return details;
    }
    private int GetScore()
    {
        return base.GetPoints() * _events.Count();
    }
    //Methods
    public override void RecordEvent()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        GoalEvent evento = new GoalEvent(today);
        _events.Add(evento);
    }
    public override void IsComplete() { }
}