public class Listing : Reflection
{
    private List<string> _responsePrompt = new List<string>();
    
    //Constructor
    public Listing(string title, string message, string promt) : base(title, message, promt)
    {

    }
    //Methods
    public void SetResponse(string response)
    {
        _responsePrompt.Add(response);
    }
}