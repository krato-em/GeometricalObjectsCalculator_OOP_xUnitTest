using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_OOP_xUnitTest.Interfaces;

namespace Calculator_OOP_xUnitTest._3DShapes
{
    public class Cube : IOneLength3D
    {
        public double SurfaceAreaCalculate(double length)
        {
            if (double.IsNaN(length))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (length <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
            else
            {
                return Math.Pow(length, 2) * 6;
            }
        }

        public double VolumeCalculate(double length)
        {
            if (double.IsNaN(length))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (length <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
            else
            {
                return Math.Pow(length, 3);
            }
        }
    }
}
