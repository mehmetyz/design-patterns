using DesignPatterns.Composite;

var circle = new Circle(10);
var rectangle = new Rectangle(2, 4);
var square = new Square(5);

var composite = new CompositeShape();
composite.Add(circle);
composite.Add(rectangle);
composite.Add(square);


Console.WriteLine("Total Area: " + composite.CalculateArea());