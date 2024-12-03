public class Reflection : Activity
{
    private List<string> _prompt = new List<string>();
    private List<string> _question = new List<string>();

    //Constructors
    public Reflection(string title, string message, string promt, string question) : base(title, message)
    {
        SetPrompt(promt);
        SetQuestion(question);
    }
    public Reflection(string title, string message, string promt) : base(title, message)
    {
        SetPrompt(promt);
    }
    //Methods
    public void SetPrompt(string promt)
    {
        _prompt.Add(promt);
    }
    public void SetQuestion(string question)
    {
        _question.Add(question);
    }
    public List<string> GetPromtList()
    {
        return _prompt;
    }
    public List<string> GetQuestionList()
    {
        return _question;
    }
}