public class Listing : Reflection
{
    private List<string> _responsePrompt = new List<string>();
    private int _numberItems;

    //Constructor
    public Listing(string title, string message, int duration, string promt) : base(title, message, duration, promt)
    {
        _numberItems = 0;
    }
    //Setters
    private void SetResponse(string response)
    {
        _responsePrompt.Add(response);
    }
    private void SetNumberOfItems()
    {
        int qnt = 0;
        foreach (string item in _responsePrompt)
        {
            qnt++;
        }
        _numberItems = qnt;
    }
    //Getters
    private int GetNumberOfItems()
    {
        SetNumberOfItems();
        return _numberItems;
    }
    //Methods
    public void InititateListingActivity()
    {
        //Choosing randomly a prompt from all possible prompts
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(base.GetPromtList().Count);
        string prompt = base.GetPromtList()[index];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(prompt);
        Console.WriteLine("");
        
        //Countdown at 5 seconds
        base.CountDown(5);

        //Clearing screen
        Console.Clear();

        //Now is time for user to input data
        Console.WriteLine("Now list your responses!!!");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        DateTime currentTime = DateTime.Now;
        do
        {
            string respon = Console.ReadLine();
            SetResponse(respon);
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        //Showing how many responses are at the end
        Console.WriteLine($"You listed {GetNumberOfItems()} items");
    }
}