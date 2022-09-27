using ShapeClassDiagram;

Circle circle = new Circle(2.5, 1.4);

circle.setRadius(2.2);
Console.WriteLine($"The area of the circle is: {circle.Area()}");
Console.WriteLine($"The location of the circle is: {circle.ToString()}");
Console.WriteLine($"The perimetar of the circle is: {circle.Perimeter()}");

Rectangle rectangle = new Rectangle(22.2, 11.2);

rectangle.setSides(22.0, 12.1);
Console.WriteLine($"The area of the rectangle is: {rectangle.Area()}");
Console.WriteLine($"The perimeter of the rectangle is: {rectangle.Perimeter()}");
Console.WriteLine($"The location of the rectangle is: {rectangle.ToString()}");