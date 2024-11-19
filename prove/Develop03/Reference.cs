public class Reference
{
    private string _title;
    private int _hideState; //1 hidded, 0 not hidded
    private List<Scripture> _scriptures = new List<Scripture>();

    //******************
    //Constructors
    //******************

    public Reference()
    {
        _title = "";
    }

    public Reference(string title)
    {
        _title = title;
    }

    //******************
    //Setters
    //******************
    public void SetReference(string reference)
    {
        _title = reference;
    }
    public void AddScripture(Scripture verse)
    {
        _scriptures.Add(verse);
    }

    //******************
    //Getters
    //******************

    //******************
    //Methods
    //******************
    private void hideState()
    {
        //1 indicate all is hidden
        int stat = 1;
        foreach (Scripture scripture in _scriptures)
        {
            //If just one of the scriptures is not hidded, then entire reference is not hidded
            if (scripture.GetHideState() != 1) { stat = 0; }
        }
        _hideState = stat;
    }
    public void PrintReference(int tries)
    {
        Console.WriteLine(_title);
        foreach (Scripture scripture in _scriptures)
        {
            scripture.PrintScripture(tries);
        }
        hideState();//Lets call hideState here to check if the entire reference is hidden
    }

}