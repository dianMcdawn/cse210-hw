public class Assignment
{
    private string _studentName;
    private string _topic;

    //Constructors
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //Method
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
    protected string GetStudentName()
    {
        return _studentName;
    }
}