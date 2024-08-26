using ShapeCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Tests.UnitTests
{
    internal class TriangleTests
    {
        /// <summary>
        /// Tests the area calculation for a triangle.
        /// </summary>
        [Test]
        public void TriangleAreaTest()
        {
            Triangle triangle = new(3, 4, 5);
            double area = triangle.CalculateArea();
            Assert.That(area, Is.EqualTo(6).Within(1e-10));
        }

        /// <summary>
        /// Tests if a triangle is right-angled.
        /// </summary>
        [Test]
        public void TriangleIsRightAngledTest()
        {
            Triangle triangle = new(3, 4, 5);
            bool isRightAngled = triangle.IsRightAngled();
            Assert.That(isRightAngled);
        }

        /// <summary>
        /// Tests that an exception is thrown when the sides do not form a valid triangle.
        /// </summary>
        [Test]
        public void TriangleInvalidSidesTest()
        {
            // Test for an invalid triangle where one side is too long to form a triangle.
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }

        /// <summary>
        /// Tests the creation of a valid triangle.
        /// </summary>
        [Test]
        public void TriangleValidSidesTest()
        {
            // Test that valid sides do not throw an exception and form a valid triangle.
            Assert.DoesNotThrow(() => new Triangle(3, 4, 5));
        }
    }
}
