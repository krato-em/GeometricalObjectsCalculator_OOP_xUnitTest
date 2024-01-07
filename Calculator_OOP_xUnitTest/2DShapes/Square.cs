using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_OOP_xUnitTest.Interfaces;

namespace Calculator_OOP_xUnitTest._2DShapes
{
    public class Square : IOneLength2D
    {
        public double AreaCalculate(double length)
        {
            if (double.IsNaN(length))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (length < 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
            else
            {
                return Math.Pow(length, 2);
            }
        }

        public double CircumferenceCalculate(double length)
        {
            if (double.IsNaN(length))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (length < 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
            else
            {
                return length * 4;
            }
        }
    }
}
