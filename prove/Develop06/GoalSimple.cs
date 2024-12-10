using System.Runtime.CompilerServices;

public class GoalSimple : Goal
{
    private bool _isComplete;
    private DateTime _dateStart;
    private DateTime _dateComplete;
    private GoalEvent _event;

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public GoalSimple(int goalType, string name, string description, int point, string difficulty, bool isComplete, DateTime dateStart, DateTime dateUpdate) : base(goalType, name, description, point, difficulty)
    {
        _isComplete = isComplete;
        _dateStart = dateStart;
        _dateComplete = dateUpdate;
    }
    //***************************************
    //                SETTERS
    //***************************************
    public override void SetNewGoalEvent(GoalEvent evento)
    {
        _event = evento;
    }
    //***************************************
    //                GETTERS
    //***************************************
    public override string GetRepresentation()
    {
        IsComplete();
        string typeGoal = "Simple Goal";
        if (_isComplete == false)
        {
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Status: Not Completed | Points : {GetScore()}";
        }
        else
        {
            return $"{typeGoal.PadRight(15)}: {base.GetName().PadRight(15)} | Started on : {_dateStart} | Status: Completed on {_dateComplete} | Points : {GetScore()}";
        }
    }
    public override string GetDetails()
    {

        string details = "";
        if (_event != null)
        {
            details = GetRepresentation() + "\nDetails:\n" + _event.GetEventSummary() + $" \nHaving completed this goal you won {base.GetPoints()} points";
        }
        else
        {
            details = GetRepresentation();
        }
        return details + "\n";
    }
    public override int GetScore()
    {
        IsComplete();
        if (_isComplete == false)
        {
            return 0;
        }
        else
        {
            return base.GetPoints();
        }
    }


    //***************************************
    //                METHODS
    //***************************************
    public override void RecordEvent()
    {
        DateTime todaytime = DateTime.Now;//Date and time
        //DateOnly today = DateOnly.FromDateTime(DateTime.Now);//Only date
        _event = new GoalEvent(todaytime);
        _dateComplete = todaytime;
        Console.WriteLine($"Your goal has been Completed!!! Congratulation, you won {base.GetPoints()} points");
    }
    public override bool IsComplete()
    {
        if (_event != null) { _isComplete = true; }
        else { _isComplete = false; }
        return _isComplete;
    }
    public override string GetStringSave(string playerName)
    {
        if (_event != null)
        {
            //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date       
            return $"{playerName};{base.GetGoalType()};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateComplete};{base.GetPoints()};0;{base.GetDifficulty()};;0;{_dateComplete}";
        }
        else
        {
            return $"{playerName};{base.GetGoalType()};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateComplete};{base.GetPoints()};0;{base.GetDifficulty()};;0;";
        }
    }
}