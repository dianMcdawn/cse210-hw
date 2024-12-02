public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //Constructors
    public MathAssignment(string name, string topic, string textBookSection, string problems) : base(name, topic)
    {
        _textbookSection = textBookSection;
        _problems = problems;
    }

    //Methods
    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}