using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_OOP_xUnitTest.Interfaces;

namespace Calculator_OOP_xUnitTest._3DShapes
{
    public class Sphere : IOneLength3D
    {
        public double SurfaceAreaCalculate(double radius)
        {
            if (double.IsNaN(radius))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (radius <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
            else
            {
                return 4 * Math.PI * Math.Pow(radius, 2);
            }
        }

        public double VolumeCalculate(double radius)
        {
            if (double.IsNaN(radius))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (radius <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
            else
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            }
        }
    }
}
