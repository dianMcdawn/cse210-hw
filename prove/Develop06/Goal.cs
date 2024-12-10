public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private string _difficulty;

    //Constructor
    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _difficulty = "";
    }
    public Goal(string name, string description, int point, string difficulty)
    {
        _name = name;
        _description = description;
        _points = point;
        _difficulty = difficulty;
    }
    //Setters
    public abstract void SetNewGoalEvent(GoalEvent evento);
    //Getters

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDifficulty()
    {
        return _difficulty;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract int GetScore();
    public abstract string GetRepresentation();
    public abstract string GetDetails();
    public abstract string GetStringSave(string playerName);

    //Methods
    public abstract void RecordEvent();
    public abstract void IsComplete();
}