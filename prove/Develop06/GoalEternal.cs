public class GoalEternal : Goal
{
    private string _periodGoal;
    private DateTime _dateStart;
    private DateTime _dateUpdate;
    private List<GoalEvent> _events = new List<GoalEvent>();

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public GoalEternal(int goalType, string name, string description, int point, string difficulty, string periodGoal, bool isComplete, DateTime dateStart, DateTime dateUpdate) : base(goalType, name, description, point, difficulty)
    {
        _periodGoal = periodGoal;
        _dateStart = dateStart;
        _dateUpdate = dateUpdate;
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
        string typeGoal = "Eternal Goal";
        return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Tries: {_events.Count()} | Last Updated: {_dateUpdate}  | Points : {GetScore()}";
    }
    public override string GetDetails()
    {
        string details = GetRepresentation() + "\nDetails:";
        foreach (GoalEvent evento in _events)
        {
            details = details + "\n" + evento.GetEventSummary() + $" where you won {base.GetPoints()} points";
        }
        return details + "\n";
    }
    public override int GetScore()
    {
        IsComplete();
        return base.GetPoints() * _events.Count();
    }
    //***************************************
    //                METHODS
    //***************************************
    public override void RecordEvent()
    {
        DateTime todaytime = DateTime.Now;//Date and time
        //DateOnly today = DateOnly.FromDateTime(DateTime.Now);//Only date
        GoalEvent evento = new GoalEvent(todaytime);
        _events.Add(evento);
        _dateUpdate = todaytime;
        Console.WriteLine($"Your goal task has been recorded!!! Congratulation, you won {GetPoints()} points");
    }
    public override bool IsComplete() { return false; }
    public override string GetStringSave(string playerName)
    {
        string data = "";
        if (_events.Count() > 0)
        {
            foreach (GoalEvent evento in _events)
            {
                //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date
                data = data + "&&" + $"{playerName};{base.GetGoalType()};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateUpdate};{base.GetPoints()};0;{base.GetDifficulty()};{_periodGoal};0;{evento.GetDate()}";
            }
        }
        else
        {
            //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date
            data = $"{playerName};{base.GetGoalType()};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateUpdate};{base.GetPoints()};0;{base.GetDifficulty()};{_periodGoal};0;";
        }
        return data;
    }
}