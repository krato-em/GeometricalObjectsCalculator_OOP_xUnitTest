using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_OOP_xUnitTest.Interfaces;

namespace Calculator_OOP_xUnitTest._2DShapes
{
    public class Rectangular : ITwoLengths
    {
        public double AreaCalculate(double lengthA, double lengthB)
        {

            IsInvalidInput(lengthA, lengthB);
            return lengthA * lengthB;
        }

        public double CircumferenceCalculate(double lengthA, double lengthB)
        {
            IsInvalidInput(lengthA, lengthB);
            return 2 * (lengthA + lengthB);
        }

        private void IsInvalidInput(double lengthA, double lengthB)
        {
            if (double.IsNaN(lengthA) || double.IsNaN(lengthB))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (lengthA <= 0 || lengthB <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
        }
    }
}
