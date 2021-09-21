using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibsFigure.Figure
{
    class Triangle : ITriangle
    {
        /// <summary>
        /// Площадь треугольника по сторонам
        /// </summary>
        /// <param A="SideA"></param>
        /// <param B="SideB"></param>
        /// <param C="SideC"></param>
        /// <returns></returns>
        public double Area(double SideA, double SideB, double SideC)
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param A="SideA"></param>
        /// <param B="SideB"></param>
        /// <param C="SideC"></param>
        /// <returns></returns>
        public bool Rigth(double SideA, double SideB, double SideC)
        {
            double SidePow_A = Math.Pow(SideA, 2);
            double SidePow_B = Math.Pow(SideB, 2);
            double SidePow_C = Math.Pow(SideC, 2);
            if (SidePow_A == (SidePow_B + SidePow_C))
            {
                return true;
            }
            if (SidePow_B == (SidePow_A + SidePow_C))
            {
                return true;
            }
            if (SidePow_C == (SidePow_A + SidePow_B))
            {
                return true;
            }
            return false;
        }
    }
}
