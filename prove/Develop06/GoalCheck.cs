public class GoalCheck : Goal
{
    private bool _isComplete;
    private int _amountCompleted;
    private int _goalToAchieve;
    private int _lesserPoints;
    private DateTime _dateStart;
    private DateTime _dateComplete;
    private List<GoalEvent> _events = new List<GoalEvent>();

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public GoalCheck(int goalType, string name, string description, int point, string difficulty, int goalToAchieve, int lesserPoints, bool isComplete, DateTime dateStart, DateTime dateUpdate) : base(goalType, name, description, point, difficulty)
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
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Tries: {_amountCompleted}/{_goalToAchieve} | Status: Not Completed | Last Updated: {_dateComplete} | Points : {GetScore()}";
        }
        else
        {
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Status: Completed on {_dateComplete} | Points : {GetScore()}";
        }
    }
    public override string GetDetails()
    {
        IsComplete();
        string details = GetRepresentation() + "\nDetails:";
        foreach (GoalEvent evento in _events)
        {
            details = details + "\n" + evento.GetEventSummary() + $" where you won {_lesserPoints} points";
        }
        if (_isComplete == true) { details = details + $"\nHaving completed this goal you won an extra {base.GetPoints()} points"; }
        return details + "\n";
    }
    public override int GetScore()
    {
        IsComplete();
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
        DateTime todaytime = DateTime.Now;//Date and time
        //DateOnly today = DateOnly.FromDateTime(DateTime.Now);//Only date
        GoalEvent evento = new GoalEvent(todaytime);
        _events.Add(evento);
        _dateComplete = todaytime;
        IsComplete();
        Console.WriteLine($"Your goal has been Completed!!! Congratulation, you won {_lesserPoints} points");
        if (_isComplete == true)
        {
            Console.WriteLine($"\nYour goal has been Completed!!! Congratulation, you won {base.GetPoints()} extra points");
        }
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