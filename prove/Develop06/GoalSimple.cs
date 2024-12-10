using System.Runtime.CompilerServices;

public class GoalSimple : Goal
{
    private bool _isComplete;
    private DateOnly _dateStart;
    private DateOnly _dateComplete;
    private GoalEvent _event;

    //constructor
    public GoalSimple(string name, string description, int point, string difficulty, bool isComplete, DateOnly dateStart, DateOnly dateUpdate) : base(name, description, point, difficulty)
    {
        _isComplete = isComplete;
        _dateStart = dateStart;
        _dateComplete = dateUpdate;
    }
    //Setter
    public override void SetNewGoalEvent(GoalEvent evento)
    {
        _event = evento;
    }
    //Getters
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
            details = GetRepresentation() + "\n" + _event.GetEventSummary();
        }
        else
        {
            details = GetRepresentation();
        }
        return details;
    }
    //Getters
    public override int GetScore()
    {
        if (_isComplete == false)
        {
            return 0;
        }
        else
        {
            return base.GetPoints();
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
    public override void SaveToText(string fileName, string playerName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //Player Name ; Goal Name ; Goal Description ; Date Start ; Date Update/Completed ; Points ; Points individual (Check) ; Difficulty ; Period ; Goal to be achieved ; Event Date       
            outputFile.WriteLine($"{playerName};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateComplete};{base.GetPoints()};0;{base.GetDifficulty()};;0;{_dateComplete}");
        }

    }
}