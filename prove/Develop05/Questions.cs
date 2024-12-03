public class Questions
{
    private string _question;
    private int _state;

    //Constructor
    public Questions (string question, int state)
    {
        _question = question;
        _state = state;
    }
    //Method
    public void SetState(int state)
    {
        _state = state;
    }
    public int GetState()
    {
        return _state;
    }
    public string GetQuestion()
    {
        return _question;
    }
}