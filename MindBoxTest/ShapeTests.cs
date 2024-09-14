using MindBoxTask;

namespace MindBoxTest
{
    public class ShapeTests
    {
        [Test]
        public void CalculateCircleArea_WithPositiveRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.AreEqual(expectedArea, circle.CalculateArea());
        }

        [Test]
        public void CalculateTriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.CalculateArea());
        }

        [Test]
        public void IsRightTriangle_WithRightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangularTriangle());
        }

        [Test]
        public void IsRightTriangle_WithNonRightTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRectangularTriangle());
        }
    }
}