public class GoalCheck : Goal
{
    private bool _isComplete;
    private int _amountCompleted;
    private int _goalToAchieve;
    private int _lesserPoints;
    private DateOnly _dateStart;
    private DateOnly _dateComplete;
    private List<GoalEvent> _events = new List<GoalEvent>();

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public GoalCheck(int goalType, string name, string description, int point, string difficulty, int goalToAchieve, int lesserPoints, bool isComplete, DateOnly dateStart, DateOnly dateUpdate) : base(goalType, name, description, point, difficulty)
    {
        _isComplete = isComplete;
        _goalToAchieve = goalToAchieve;
        _lesserPoints = lesserPoints;
        _dateStart = dateStart;
        _dateComplete = dateUpdate;
    }
    //***************************************
    //                SETTERS
    //***************************************
    public override void SetNewGoalEvent(GoalEvent evento)
    {
        _events.Add(evento);
    }
    //***************************************
    //                GETTERS
    //***************************************
    public override string GetRepresentation()
    {
        IsComplete();
        string typeGoal = "Check Goal";
        if (_isComplete == false)
        {
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Tries: {_events.Count()} |  Status: Not Completed | Last Updated: {_dateComplete} | Points : {GetScore()}";
        }
        else
        {
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Status: Completed on {_dateComplete} | Points : {GetScore()}";
        }
    }
    public override string GetDetails()
    {
        string details = GetRepresentation() + "\nDetails:";
        foreach (GoalEvent evento in _events)
        {
            details = details + "\n" + evento.GetEventSummary();
        }
        return details + "\n";
    }
    public override int GetLessPoints()
    {
        return _lesserPoints;
    }
    public override int GetScore()
    {
        if (_isComplete == false)
        {
            return _events.Count() * _lesserPoints;
        }
        else
        {
            return base.GetPoints() + (_events.Count() * _lesserPoints);
        }
    }
    //***************************************
    //                METHODS
    //***************************************
    public override void RecordEvent()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        GoalEvent evento = new GoalEvent(today);
        _events.Add(evento);
        _dateComplete = today;
    }
    public override bool IsComplete()
    {
        if (_events.Count() == _goalToAchieve) { _isComplete = true; _amountCompleted = _goalToAchieve; }
        else { _isComplete = false; _amountCompleted = _events.Count(); }
        return _isComplete;
    }
    public override string GetStringSave(string playerName)
    {
        string data = "";
        if (_events.Count() > 0)
        {
            foreach (GoalEvent evento in _events)
            {
                //Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date
                data = data + "&&" + $"{playerName};{base.GetGoalType()};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateComplete};{base.GetPoints()};{_lesserPoints};{base.GetDifficulty()};;{_goalToAchieve};{evento.GetDate()}";
            }
        }
        else
        {
            // Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date
            data = $"{playerName};{base.GetGoalType()};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateComplete};{base.GetPoints()};{_lesserPoints};{base.GetDifficulty()};;{_goalToAchieve};";
        }
        return data;
    }
}