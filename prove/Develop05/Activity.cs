public class Activity
{
    private string _title;
    private string _message;

    //Constructor
    public Activity(string title, string message)
    {
        _title = title;
        _message = message;
    }

    //Methods
    public string GetTitle()
    {
        return _title;
    }
    public string GetMessage()
    {
        return _message;
    }
}