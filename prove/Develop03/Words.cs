public class Words
{
    private string _word;
    private string _hidden;
    private int _state; //0 show, 1 hidden

    //Constructors
    public Words()
    {
        _word = "";
        _state = 0;
        setHiddenWord(_word);
    }
    public Words(string word)
    {
        _word = word;
        _state = 0;
        setHiddenWord(_word);
    }
    public Words(string word, int state)
    {
        _word = word;
        _state = state;
        setHiddenWord(_word);
    }

    //Setter
    private void setHiddenWord(string word)
    {
        int lng = _word.Length;
        for (int i = 0; i < lng; i++)
        {
            _hidden = _hidden + "_";
        }
    }
    public void setState(int state)
    {
        _state = state;
    }

    //Getter
    public string getWordReplace()
    {
        return _hidden;
    }

    public int getState()
    {
        return _state;
    }

    //Printer
    public void printWord()
    {
        //Depending on state is the word that will be printed
        if (_state == 1)
        {
            Console.Write(_hidden);
        }
        else
        {
            Console.Write(_word);
        }
    }
}