using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Shapes
{
    /// <summary>
    /// Сircle shape with a specific radius.
    /// </summary>
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }

            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
