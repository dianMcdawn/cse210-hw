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
    public void InitiateBreathActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        DateTime currentTime = DateTime.Now;
        int breathCount = 0;
        do
        {
            Console.Write("\b \b");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in...4");
            int i = 4;
            do
            {
                Thread.Sleep(1000);
                i--;
                Console.Write("\b \b");
                Console.Write(i);
            } while (i > 0);
            Console.WriteLine("");
            Console.Write("Breathe out...6");
            int j = 6;
            do
            {
                Thread.Sleep(1000);
                j--;
                Console.Write("\b \b");
                Console.Write(j);
            } while (j > 0);
            Console.WriteLine("");
            currentTime = DateTime.Now;
            breathCount++;
        } while (currentTime < futureTime);
        //Counting how many times in and out where made
        SetBreathCount(breathCount);
    }
}