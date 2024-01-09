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
            IsInvalidInput(length);
            return Math.Pow(length, 2);
        }

        public double CircumferenceCalculate(double length)
        {
            IsInvalidInput(length);
            return length * 4;
        }

        private void IsInvalidInput (double length)
        {
            if (double.IsNaN(length))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (length <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
        }
    }
}
