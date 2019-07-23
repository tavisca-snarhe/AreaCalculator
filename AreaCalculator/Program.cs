using System;

namespace AreaCalculator
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea() => (3.14 * radius * radius);
    }

    public class Rectangle : IShape
    {
        double length, breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea() => length * breadth;
    }

    public class Square : IShape
    {
        double length;

        public Square(double length)
        {
            this.length = length;
        }

        public double CalculateArea() => length * length;
    }

    public class Triangle : IShape
    {
        double BaseLength, height;

        public Triangle(double BaseLength, double height)
        {
            this.BaseLength = BaseLength;
            this.height = height;
        }

        public double CalculateArea() => (0.5 * (BaseLength * height));
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
