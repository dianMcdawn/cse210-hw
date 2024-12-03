public class Reflection : Activity
{
    private List<string> _prompt = new List<string>();
    private List<Questions> _question = new List<Questions>();

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
        Questions quest = new Questions(question, 0);
        _question.Add(quest);
    }
    public List<string> GetPromtList()
    {
        return _prompt;
    }
    public List<Questions> GetQuestionList()
    {
        return _question;
    }
}