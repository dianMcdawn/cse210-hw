public class Reference
{
    private string _title;
    private List<Scripture> _scriptures = new List<Scripture>();

    //******************
    //Constructors
    //******************

    public Reference()
    {
        _title = "";
    }

    public Reference(string title)
    {
        _title = title;
    }

    //******************
    //Setters
    //******************
    public void SetReference(string reference)
    {
        _title = reference;
    }
    public void AddScripture(Scripture verse)
    {
        _scriptures.Add(verse);
    }

    //******************
    //Getters
    //******************

    //******************
    //Methods
    //******************
    public void PrintReference(int tries)
    {
        Console.WriteLine(_title);
        foreach (Scripture scripture in _scriptures)
        {
            scripture.PrintScripture(tries);
        }
    }

}