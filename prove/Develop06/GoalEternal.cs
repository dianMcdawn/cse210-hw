public class GoalEternal : Goal
{
    private string _periodGoal;
    private DateOnly _dateStart;
    private DateOnly _dateUpdate;
    private List<GoalEvent> _events = new List<GoalEvent>();

    //constructor
    public GoalEternal(string name, string description, int point, string difficulty, string periodGoal, bool isComplete, DateOnly dateStart, DateOnly dateUpdate) : base(name, description, point, difficulty)
    {
        _periodGoal = periodGoal;
        _dateStart = dateStart;
        _dateUpdate = dateUpdate;
    }
    //Setter
    public override void SetNewGoalEvent(GoalEvent evento)
    {
        _events.Add(evento);
    }
    //Getters
    public override string GetRepresentation()
    {
        string typeGoal = "Eternal Goal";
        return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Tries: {_events.Count()} | Last Updated: {_dateUpdate}  | Points : {GetScore()}";
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
    public override int GetScore()
    {
        return base.GetPoints() * _events.Count();
    }
    //Methods
    public override void RecordEvent()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        GoalEvent evento = new GoalEvent(today);
        _events.Add(evento);
        _dateUpdate = today;
    }
    public override void IsComplete() { }
    public override void SaveToText(string fileName, string playerName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            if (_events.Count() > 0)
            {
                foreach (GoalEvent evento in _events)
                {
                    //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date
                    outputFile.WriteLine($"{playerName};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateUpdate};{base.GetPoints()};0;{base.GetDifficulty()};{_periodGoal};0;{evento.GetDate()}");
                }
            }
            else
            {
                //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date
                outputFile.WriteLine($"{playerName};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateUpdate};{base.GetPoints()};0;{base.GetDifficulty()};{_periodGoal};0;");
            }
        }

    }
}