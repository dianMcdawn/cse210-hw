public class Comment
{
    private string _name;
    private string _comment;

    //Constructors
    public Comment()
    {
        _name="";
        _comment="";
    }
    public Comment(string name)
    {
        _name=name;
        _comment="";
    }
    public Comment(string name, string comment)
    {
        _name=name;
        _comment=comment;
    }

    //Methods
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment}");
    }
}