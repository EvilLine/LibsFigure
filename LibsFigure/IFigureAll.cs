using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibsFigure
{
    public interface IFigureAll
    {
        double Area(double Radius);
        double Area(double SideA, double SideB, double SideC);
        bool Rigth(double SideA, double SideB, double SideC);
    }
}
