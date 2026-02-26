


using System.Diagnostics;

System.Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

List<Shape> shapes = new List<Shape>();

for(int i = 1; i <= n; i++)
{
    System.Console.Write($"Shape #{i} data:");
    System.Console.Write("Rectangle or Circle (r/c)? ");
    char type = char.Parse(Console.ReadLine());
    System.Console.Write("Color (Black/Blue/Red): ");
    Color color = (Color)Enum.Parse<Color>(Console.ReadLine());
    
    switch(type){

        case 'r':
            System.Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            System.Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(color, width, height));
            break;
        case 'c':
            System.Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            shapes.Add(new Circle(color, radius));
            break;
    }

}

foreach