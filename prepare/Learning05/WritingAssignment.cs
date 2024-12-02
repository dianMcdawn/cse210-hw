public class WritingAssignment : Assignment
{
    private string _title;

    //Constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //Methods
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return _title + " by " + studentName;
    }
}