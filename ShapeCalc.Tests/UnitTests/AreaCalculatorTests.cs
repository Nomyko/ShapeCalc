using ShapeCalc.Shapes;

namespace ShapeCalc.Tests
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        /// <summary>
        /// Tests the area calculation using the AreaCalculator utility.
        /// </summary>
        [Test]
        public void AreaCalculatorTest()
        {
            IShape circle = new Circle(5);
            IShape triangle = new Triangle(3, 4, 5);
            AreaCalculator calculator = new();

            double circleArea = calculator.CalculateShapeArea(circle);
            double triangleArea = calculator.CalculateShapeArea(triangle);

            Assert.That(circleArea, Is.EqualTo(Math.PI * 25).Within( 1e-10));
            Assert.That(triangleArea, Is.EqualTo(6).Within(1e-10));
        }
    }
}