using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Shapes
{
    /// <summary>
    /// Triangle shape defined by three sides.
    /// </summary>
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("The given sides do not form a valid triangle.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2; // Calculates the semiperimeter of the triangle

            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Determines if the triangle is a right-angled triangle.
        /// </summary>
        public bool IsRightAngled()
        {
            double[] sides = [SideA, SideB, SideC];
            Array.Sort(sides); // After sorting we know, that sides[2] is the hypotenuse 

            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }

        /// <summary>
        /// Validates whether the given sides can form a triangle.
        /// </summary>
        /// <param name="sideA">The first side.</param>
        /// <param name="sideB">The second side.</param>
        /// <param name="sideC">The third side.</param>
        /// <returns>True if the sides can form a triangle; otherwise, false.</returns>
        private static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) 
                && (sideA + sideC > sideB) 
                && (sideB + sideC > sideA);
        }
    }
}
