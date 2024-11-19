public class Reference
{
    private string _title;
    private List<Scripture> _scriptures = new List<Scripture>();

    //Constructors

    //Setters
    public void setReference(string reference)
    {
        _title = reference;
    }
    public void addScripture(Scripture verse)
    {
        _scriptures.Add(verse);
    }

    //Printers
    public void printReference(int tries)
    {
        Console.WriteLine(_title);
        foreach (Scripture scripture in _scriptures)
        {
            scripture.printScripture(tries);
        }
    }

}