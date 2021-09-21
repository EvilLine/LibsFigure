using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibsFigure;
using System;

namespace LibsFigureTest
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void TestAreaCircle()
        {
            FigureAll figureAll = new FigureAll();            
            double actual = figureAll.Area(5);            
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestAreaTriangle()
        {
            FigureAll figureAll = new FigureAll();
            double actual = figureAll.Area(5, 6, 5);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestAreaRigth()
        {
            FigureAll figureAll = new FigureAll();
            bool actual = figureAll.Rigth(1, 2, 3);
            Assert.IsNotNull(actual);
        }

    }
}
