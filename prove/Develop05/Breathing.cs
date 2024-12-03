public class Breathing : Activity
{
    private int _breathCount;

    //Constructor
    public Breathing(string title, string message) : base(title, message)
    {
        _breathCount = 0;
    }
    //Method
    public void SetBreathCount(int count)
    {
        _breathCount = count;
    }
}