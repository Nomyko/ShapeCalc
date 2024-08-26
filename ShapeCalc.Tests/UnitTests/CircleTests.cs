using ShapeCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Tests.UnitTests
{
    [TestFixture]
    internal class CircleTests
    {
        /// <summary>
        /// Tests that an exception is thrown when an invalid radius is provided.
        /// </summary>
        [Test]
        public void CircleInvalidRadiusTest()
        {
            // Test for an invalid radius (zero or negative).
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        /// <summary>
        /// Tests the area calculation for a valid circle.
        /// </summary>
        [Test]
        public void CircleAreaTest()
        {
            Circle circle = new(5);
            double area = circle.CalculateArea();
            Assert.That(area, Is.EqualTo(Math.PI * 25).Within(1e-10));
        }
    }
}
