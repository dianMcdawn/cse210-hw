public class Entry
{
    public string _date;
    public string _question;
    public string _entry;

    public void Display()
    {
        Console.WriteLine($"Date {_date} - Promt {_question}");
        Console.WriteLine($"{_entry}");
    }
}