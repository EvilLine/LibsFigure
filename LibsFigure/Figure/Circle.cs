using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibsFigure.Figure
{
    class Circle : ICircle
    {
        /// <summary>
        /// Площадь окружности по Радиусу
        /// </summary>
        /// <param name="Radius"></param>
        /// <returns></returns>
        public double Area(double Radius)
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
