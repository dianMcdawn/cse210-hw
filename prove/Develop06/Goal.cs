public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private string _difficulty;
    private int _goalType;

    //********************************************
    //                CONSTRUCTORS
    //********************************************
    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _difficulty = "";
    }
    public Goal(int goalType, string name, string description, int point, string difficulty)
    {
        _name = name;
        _description = description;
        _points = point;
        _difficulty = difficulty;
        _goalType = goalType;
    }
    //***************************************
    //                SETTERS
    //***************************************
    public abstract void SetNewGoalEvent(GoalEvent evento);

    //***************************************
    //                GETTERS
    //***************************************
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
    public abstract int GetLessPoints();
    public int GetGoalType()
    {
        return _goalType;
    }
    public abstract int GetScore();
    public abstract string GetRepresentation();
    public abstract string GetDetails();
    public abstract string GetStringSave(string playerName);

    //***************************************
    //                METHODS
    //***************************************
    public abstract void RecordEvent();
    public abstract bool IsComplete();
}