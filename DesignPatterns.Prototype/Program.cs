using DesignPatterns.Prototype;

var car1 = new ToyCar("BLUE", 10, 10, 10);

var car2 = (ToyCar)car1.Clone();

car2.Color = "RED";
car2.Height = 20;
car2.Width = 30;
car2.Depth = 50;


car1.Info();
Console.WriteLine("-------------------------------");
car2.Info();