public class Circle: Shape
{
    public double Radius { get; set; }

    public Circle(){}

    public Circle(Color color, double radius) : base (color)
    {
        Radius = radius;
    }

    public override double Area()  => Math.PI * Radius * Radius;

}