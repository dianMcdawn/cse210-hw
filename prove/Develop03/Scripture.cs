public class Scripture
{
    private string _scriptures;
    private List<Words> _words = new List<Words>();

    //Constructors
    public Scripture()
    {
        _scriptures = "";
    }
    public Scripture(string scripture)
    {
        _scriptures = scripture;
        setWords();
    }

    //Setter
    public void setScripture(string scripture)
    {
        _scriptures = scripture;
        setWords();
    }
    private void setWords()
    {
        string[] words = _scriptures.Split(" ");
        foreach (string word in words)
        {
            Words wordAlone = new Words(word);
            _words.Add(wordAlone);
        }
    }
    //This will hide randomly 1 to 3 words, if the try is not the first one
    private void hiddeWords(int tries)
    {
        if (tries > 0)
        {
            int count = _words.Count;
            Random rand = new Random();
            int goal = rand.Next(3);
            for (int i = 0; i < goal; i++)
            {
                Random ind = new Random();
                int index = ind.Next(count);

                //Checking if the word is already hidded, will continue with another word until find one
                if (_words[index].getState() == 1) { i--; }
                //If not, it is hidded
                else { _words[index].setState(1); }
            }
        }
    }

    //Printer
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