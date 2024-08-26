using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Shapes
{
    /// <summary>
    /// Interface for geometric shapes, ensuring that all shapes can calculate their area.
    /// </summary>
    public interface IShape
    {
        double CalculateArea();
    }
}
