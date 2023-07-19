// See https://aka.ms/new-console-template for more information
using July_19_Traingle;

Shape obj1 = new Triangle(3, 10, 12, 15);
Shape obj2 = new Rectangle(2, 10, 5);
Shape obj3 = new Square(2, 10);
double area1 = obj1.CalculateArea();
Console.WriteLine($"Area of Triangle is {area1} ");
double area2 = obj2.CalculateArea();
Console.WriteLine($"Area of Triangle is {area2} ");
double area3 = obj3.CalculateArea();
Console.WriteLine($"Area of Triangle is {area3} ");
