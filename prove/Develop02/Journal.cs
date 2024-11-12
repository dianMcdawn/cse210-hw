public class Journal
{
    public string _name;
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Entries:");
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"{e}");
        }
    }
}