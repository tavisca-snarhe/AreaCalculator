using AreaCalculator;
using Xunit;

namespace AreaCalculatorTests
{
    public class AreaTest
    {
        [Fact]
        public void CircleAreaTest()
        {
            IShape circle = new Circle(12);
            double ExpectedArea = 452.16;

            Assert.Equal(ExpectedArea, circle.CalculateArea(), 1);
        }

        [Fact]
        public void RectangleAreaTest()
        {
            IShape rectangle = new Rectangle(5, 5);
            double ExpectedArea = 25;

            Assert.Equal(ExpectedArea, rectangle.CalculateArea(), 1);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            IShape triangle = new Triangle(5, 7);
            double ExpectedArea = 17.5;

            Assert.Equal(ExpectedArea, triangle.CalculateArea(), 1);
        }

        [Fact]
        public void SquareAreaTest()
        {
            IShape square = new Square(6);
            double ExpectedArea = 36;

            Assert.Equal(ExpectedArea, square.CalculateArea(), 1);
        }
    }
}
