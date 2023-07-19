using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July_19_Traingle
{
    public abstract class Shape
    {
        public Shape(int sides)
        {
            NoOfSides = sides;
        }
        public int NoOfSides { get; set; }
        public abstract void DisplayNoOfSides();
        public abstract double CalculateArea();
    }

    class Triangle: Shape
    {
        public Triangle(int sides, int side1, int side2, int side3 ) : base(sides)
        {
            NoOfSides = sides;
            SideLength1 = side1;
            SideLength2 = side2;
            SideLength3 = side3;
        }
        public int SideLength1 { get; set; }
        public int SideLength2 { get; set; }
        public int SideLength3 { get; set; }

        public override double CalculateArea()
        {
            double S = (SideLength1 + SideLength2 + SideLength3) / 2;
            return S * (S - SideLength1) * (S - SideLength2) * (S - SideLength3);
        }

        public override void DisplayNoOfSides()
        {
            Console.WriteLine("Halleo");
        }
    }

    class Square : Shape
    {
        public Square(int sides, int side) : base(side)
        {
            NoOfSides = sides;
            Length = side;
            
        }
        public int Length { get; set; }
       

        public override double CalculateArea()
        {
            return Length* Length;
        }

        public override void DisplayNoOfSides()
        {
            Console.WriteLine("Halleo");
        }
    }

    class Rectangle : Shape
    {
        private static int side;

        public Rectangle(int sides, int side1, int side2) : base(side)
        {
            NoOfSides = sides;
            Length = side1;
            Width = side2;

        }
        public int Length { get; set; }
        public int Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void DisplayNoOfSides()
        {
            Console.WriteLine("Halleo");
        }
    }

}
