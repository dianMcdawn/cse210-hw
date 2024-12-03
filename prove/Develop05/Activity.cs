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

    //Setters
    private void SetDuration(int duration)
    {
        _duration = duration;
    }
    private string GetTitle()
    {
        return _title;
    }
    //Getters
    private string GetMessage()
    {
        return _message;
    }
    public int GetDuration()
    {
        return _duration;
    }
    //Methods
    public void ShowAnimationWheel()
    {
        Console.Write("+");
        for (int i = 0; i < 8; i++)
        {
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("x");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("+");
        }
        Console.Write("\b \b");
    }
    public void ShowSecondWheel()
    {
        Console.Write("|");
        for (int j = 0; j < 4; j++)
        {
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
        }
        Console.Write("\b \b");
    }
    public void CountDown(int start)
    {
        Console.Write($"You may begin in: {start}");
        do
        {
            Thread.Sleep(1000);
            start--;
            Console.Write("\b \b");
            Console.Write(start);
        } while (start > 0);
    }
    public void InitiatingActivity()
    {
        //Clearing screen
        Console.Clear();

        //Showing title and message according the activity
        Console.WriteLine("Welcome to the " + _title + " Activity");
        Console.WriteLine("");
        Console.WriteLine(_message);
        Console.Write("How long in seconds (aprox.), would you want to work in this activity: ");
        string duration = Console.ReadLine();
        int seconds = int.Parse(duration);

        //Setting Duration
        SetDuration(seconds);

        //Clearing screen
        Console.Clear();

        //Waiting room
        Console.WriteLine("Get ready..");
        ShowAnimationWheel();
    }
    public void EndingActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        ShowAnimationWheel();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title} Activity.");
        ShowAnimationWheel();
    }
}