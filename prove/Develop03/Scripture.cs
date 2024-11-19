public class Scripture
{
    private string _scriptures;
    private string _scriptureHidded;
    private int _stateHide;
    private List<Words> _words = new List<Words>();

    //******************
    //Constructors
    //******************
    public Scripture()
    {
        _scriptures = "";
        _scriptureHidded = "";
        _stateHide = 0;
    }
    public Scripture(string scripture)
    {
        _scriptures = scripture;
        _stateHide = 0;
        setWords();
        setAllHidden();
    }

    //******************
    //Setters
    //******************
    public void setScripture(string scripture)
    {
        _scriptures = scripture;
        setWords();
        setAllHidden();
    }
    //Generate every word from the scripture
    private void setWords()
    {
        string[] words = _scriptures.Split(" ");
        foreach (string word in words)
        {
            Words wordAlone = new Words(word);
            _words.Add(wordAlone);
        }
    }
    //Transform the entiry scripture into a hidden one. This will help to know if everyword had been hidded.
    private void setAllHidden()
    {
        int count = 0;
        int total = _words.Count;
        foreach (Words word in _words)
        {
            _scriptureHidded = word.getWordReplace();
            count = count + 1;
            if (count != total) { _scriptureHidded = _scriptureHidded + " "; }
        }
    }

    //******************
    //Getters
    //******************

    private string getCurrentScriptureState()
    {
        string current = "";
        int count = 0;
        int total = _words.Count;
        foreach (Words word in _words)
        {
            current = word.getcurrentWord();
            count = count + 1;
            if (count != total) { Console.Write(" "); }
        }
        return current;
    }

    //******************
    //Methods
    //******************

    //This will hide randomly 1 to 3 words, if the try is not the first one
    private void hiddeWords(int tries)
    {
        if (tries > 0)
        {
            int count = _words.Count;
            Random rand = new Random();
            int goal = rand.Next(1, 2);
            for (int i = 0; i < goal; i++)
            {
                Random ind = new Random();
                int index = ind.Next(count);

                //Checking if the word is already hidded. It will continue with another word until find one
                if (_words[index].getState() == 1) { i--; }
                //If not, it is hidded
                else { _words[index].setState(1); }

                //Cheking if entire scripture is hidded
                if (getCurrentScriptureState() == _scriptureHidded)
                {
                    _stateHide = 1; //Declare that the entire scripture is hidden
                    i = goal; //Jump inmediatly to the end of the loop
                }
            }
        }
    }

    public void printScripture(int tries)
    {
        int total = _words.Count;
        int count = 0;
        foreach (Words word in _words)
        {
            hiddeWords(tries);
            word.printWord();
            count = count + 1;
            if (count != total) { Console.Write(" "); }
        }
    }
}