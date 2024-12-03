public class Breathing : Activity
{
    private int _breathCount;

    //Constructor
    public Breathing(string title, string message, int duration) : base(title, message, duration)
    {
        _breathCount = 0;
    }
    //Method
    public void SetBreathCount(int count)
    {
        _breathCount = count;
    }
}