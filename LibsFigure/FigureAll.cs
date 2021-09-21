using LibsFigure.Figure;

namespace LibsFigure
{
    public class FigureAll : IFigureAll, ICircle, ITriangle
    {
        public double Area(double Radius)
        {
            return Area(Radius);
        }

        public double Area(double SideA, double SideB, double SideC)
        {
            return Area(SideA, SideB, SideC);
        }

        public bool Rigth(double SideA, double SideB, double SideC)
        {
            return Rigth(SideA, SideB, SideC);
        }
    }
}
