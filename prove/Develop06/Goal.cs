public abstract class Goal
{
    private string _name;
    private string _description;
    private int _isAchieved;
    private int _points;
    private int _totalPoints;
    private string _difficulty;

    //Constructor
    public Goal()
    {
        _name = "";
        _description = "";
        _isAchieved = 0;
        _totalPoints = 0;
        _difficulty = "";
    }
    public Goal(string name, string description, int point, string difficulty)
    {
        _name = name;
        _description = description;
        _isAchieved = 0;
        _points = point;
        _totalPoints = 0;
        _difficulty = difficulty;
    }
    //Getters

    public string GetName()
    {
        return _name;
    }
    public string GetDetails()
    {
        return _description;
    }
    public abstract string GetRepresentation();

    //Methods
    public abstract void RecordEvent();
    public abstract void IsComplete();
}