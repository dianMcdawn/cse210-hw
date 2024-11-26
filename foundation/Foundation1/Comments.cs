public class Comments
{
    private string _name;
    private string _comment;

    //Constructors
    public Comments()
    {
        _name="";
        _comment="";
    }
    public Comments(string name)
    {
        _name=name;
        _comment="";
    }
    public Comments(string name, string comment)
    {
        _name=name;
        _comment=comment;
    } 
}