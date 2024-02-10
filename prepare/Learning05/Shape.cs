public class Shape
{
    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    //Initializing color variable
    public Shape(string color) 
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}