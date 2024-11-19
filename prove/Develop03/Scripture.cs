public class Scripture
{
    private string _scriptures;
    private string _scriptureHidded;
    private int _hideState;
    private List<Words> _words = new List<Words>();

    //******************
    //Constructors
    //******************
    public Scripture()
    {
        _scriptures = "";
        _scriptureHidded = "";
        _hideState = 0;
    }
    public Scripture(string scripture)
    {
        _scriptures = scripture;
        _hideState = 0;
        SetWords();
        SetAllHidden();
    }

    //******************
    //Setters
    //******************
    public void setScripture(string scripture)
    {
        _scriptures = scripture;
        SetWords();
        SetAllHidden();
    }
    //Generate every word from the scripture
    private void SetWords()
    {
        string[] words = _scriptures.Split(" ");
        foreach (string word in words)
        {
            Words wordAlone = new Words(word);
            _words.Add(wordAlone);
        }
    }
    //Transform the entiry scripture into a hidden one. This will help to know if everyword had been hidded.
    private void SetAllHidden()
    {
        int count = 0;
        int total = _words.Count;
        foreach (Words word in _words)
        {
            _scriptureHidded = word.GetWordReplace();
            count = count + 1;
            if (count != total) { _scriptureHidded = _scriptureHidded + " "; }
        }
    }

    //******************
    //Getters
    //******************

    public int GetHideState()
    {
        return _hideState;
    }

    private string GetCurrentScriptureState()
    {
        string current = "";
        int count = 0;
        int total = _words.Count;
        foreach (Words word in _words)
        {
            current = word.GetcurrentWord();
            count = count + 1;
            if (count != total) { Console.Write(" "); }
        }
        return current;
    }

    //******************
    //Methods
    //******************

    //This will hide randomly 1 to 3 words, if the try is not the first one
    private void HiddeWords(int tries)
    {
        if (tries > 0)
        {
            int count = _words.Count;
            Random rand = new Random();
            int goal = rand.Next(1, 3);
            for (int i = 0; i < goal; i++)
            {
                Random ind = new Random();
                int index = ind.Next(count);

                //Checking if the word is already hidded. It will continue with another word until find one
                if (_words[index].GetState() == 1) { i--; }
                //If not, it is hidded
                else { _words[index].SetState(1); }

                //Cheking if entire scripture is hidded
                if (GetCurrentScriptureState() == _scriptureHidded)
                {
                    _hideState = 1; //Set the hidden state to 1
                    i = goal; //Jump inmediatly to the end of the loop
                }
            }
        }
    }

    public void PrintScripture(int tries)
    {
        int total = _words.Count;
        int count = 0;
        HiddeWords(tries);
        foreach (Words word in _words)
        {
            word.PrintWord();
            count = count + 1;
            if (count != total) { Console.Write(" "); }
        }
    }
}