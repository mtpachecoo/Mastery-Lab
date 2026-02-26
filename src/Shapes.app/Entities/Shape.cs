public abstract class Shape
{
    public Color _color{get; set;}

    public Shape(){}

    public Shape(Color color)
    {
        _color = color;
    }
    
    public abstract double Area();

} 