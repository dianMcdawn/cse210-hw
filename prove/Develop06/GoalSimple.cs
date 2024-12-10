using System.Runtime.CompilerServices;

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
        _dateComplete = date;
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
        string details = GetRepresentation() + "\n" + _event.GetEventSummary();
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
            outputFile.WriteLine($"{playerName};{base.GetName()};{base.GetDescription()};{_dateStart};{_dateComplete};{base.GetPoints()};0;{base.GetDifficulty()};0;0;{_dateComplete}");
        }

    }
}