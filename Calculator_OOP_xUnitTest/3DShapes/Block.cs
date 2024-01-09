using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_OOP_xUnitTest.Interfaces;

namespace Calculator_OOP_xUnitTest._3DShapes
{
    public class Block : IThreeLenghts
    {
        public double SurfaceAreaCalculate(double lengthA, double lengthB, double lengthC)
        {
            IsInvalidInput(lengthA, lengthB, lengthC);
            return 2 * (lengthA * lengthB) + 2 * (lengthA * lengthC) + 2 * (lengthB * lengthC);
        }

        public double VolumeCalculate(double lengthA, double lengthB, double lengthC)
        {
            IsInvalidInput(lengthA, lengthB, lengthC);
            return lengthA * lengthB * lengthC;
        }
        private void IsInvalidInput(double lengthA, double lengthB, double lengthC)
        {
            if (double.IsNaN(lengthA) || double.IsNaN(lengthB) || double.IsNaN(lengthC))
            {
                throw new System.FormatException("The input must be a number.");
            }
            else if (lengthA <= 0 || lengthB <= 0 || lengthC <= 0)
            {
                throw new System.ArgumentException("The number can't be of a negative value.");
            }
        }
    }
}
