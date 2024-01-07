using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_OOP_xUnitTest.Interfaces
{
    public interface IThreeLenghts
    {
        double SurfaceAreaCalculate(double lengthA, double lengthB, double lengthC);
        double VolumeCalculate(double lengthA, double lengthB, double lengthC);
    }
}
