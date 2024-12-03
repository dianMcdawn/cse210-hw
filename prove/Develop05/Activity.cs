public class Activity
{
    private string _title;
    private string _message;
    private int _duration;

    //Constructor
    public Activity(string title, string message, int duration)
    {
        _title = title;
        _message = message;
        _duration = duration;
    }

    //Methods
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetMessage()
    {
        return _message;
    }
}