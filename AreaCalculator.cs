using ShapeCalc.Shapes;

namespace ShapeCalc
{
    /// <summary>
    /// Utility class for calculating the area of any shape implementing the IShape interface.
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Calculates the area of a given shape.
        /// </summary>
        /// <param name="shape">The shape whose area is to be calculated.</param>
        /// <returns>The area of the shape.</returns>
        public double CalculateShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
