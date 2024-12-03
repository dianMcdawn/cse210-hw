public class Listing : Reflection
{
    private List<string> _responsePrompt = new List<string>();
    private int _numberItems;

    //Constructor
    public Listing(string title, string message, int duration, string promt) : base(title, message, duration, promt)
    {
        _numberItems = 0;
    }
    //Methods
    public void SetResponse(string response)
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
    public int GetNumberOfItems()
    {
        SetNumberOfItems();
        return _numberItems;
    }
}