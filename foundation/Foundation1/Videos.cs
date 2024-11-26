public class Entry
{
    private string _title;
    private string _author;
    private string _lenght; //Length in seconds
    private List<Comments> _comments = new List<Comments>();

    //Constructors
    public Entry()
    {
        _title="";
        _author="",
        _length=0;
    }
    public Entry(string title)
    {
        _title=title;
        _author="",
        _length=0;
    }
    public Entry(string title, string author)
    {
        _title=title;
        _author=author,
        _length=0;
    }
    public Entry(string title, string author, int seconds)
    {
        _title=title;
        _author=author,
        _length=seconds;
    }

    //Setters
    public void SetNewComment(string name, string comment){
        Comments newcom = new Comments(name,comment);
        _comments.Add(newcom);
    }

    public void Display()
    {
        Console.WriteLine($"Date {_title} - Promt {_author}");
        Console.WriteLine($"{_lenght}");
    }
}