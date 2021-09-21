using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibsFigure.Figure
{
    interface ITriangle
    {
        double Area(double sideA, double sideB, double sideC);
        bool Rigth(double sideA, double sideB, double sideC);
    }
}
