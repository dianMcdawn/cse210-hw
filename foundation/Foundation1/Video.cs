public class Video
{
    private string _title;
    private string _author;
    private string _lenght; //Length in seconds
    private List<Comment> _comments = new List<Comment>();

    //Constructors
    public Video()
    {
        _title="";
        _author="",
        _length=0;
    }
    public Video(string title)
    {
        _title=title;
        _author="",
        _length=0;
    }
    public Video(string title, string author)
    {
        _title=title;
        _author=author,
        _length=0;
    }
    public Video(string title, string author, int seconds)
    {
        _title=title;
        _author=author,
        _length=seconds;
    }

    //Setters
    public void SetNewComment(string name, string comment){
        Comment newcom = new Comment(name,comment);
        _comments.Add(newcom);
    }


    //Methods
    public void Display()
    {
        Console.WriteLine($"Video Title: {_title} - Author: {_author} - Lenght: {_lenght}sec");
        int numberComments = ShowCommentQuantity();
        Console.WriteLine($"Number of comments: {numberComments}");
        foreach(comments as c in _comments)
        {
            c.Display();
        }
    }

    private int ShowCommentQuantity()
    {
        int count = 0;
        foreach(comments as c in _comments)
        {
            count++;
        }
        return count;
    }
}