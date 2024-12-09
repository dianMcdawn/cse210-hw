public class Shape
{
    private string _color;

    //Constructor
    public Shape()
    {
        _color = "white";
    }
    public Shape(string color)
    {
        _color = color;
    }
    //Setter
    public void SetColor(string color)
    {
        _color = color;
    }
    //Getter
    public string Getcolor()
    {
        return _color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}