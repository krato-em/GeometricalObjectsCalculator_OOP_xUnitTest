using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_OOP_xUnitTest.Interfaces;

namespace Calculator_OOP_xUnitTest._2DShapes
{
    public class Circle : IOneLength2D
    {
        public double AreaCalculate(double radius)
        {
            IsInvalidInput(radius);
            return Math.PI * Math.Pow(radius, 2);
        }

        public double CircumferenceCalculate(double radius)
        {
            IsInvalidInput(radius);
            return 2 * Math.PI * radius;
        }

        private void IsInvalidInput(double radius)
        {
            if (double.IsNaN(radius))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (radius <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
        }
    }
}
