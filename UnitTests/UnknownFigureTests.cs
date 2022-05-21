using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnknownFigureTests
    {
       [TestMethod]
        public void UnknownFigure_CalculateAreaTriangleTest()
        {
            Figure unknownFigure = new Triangle(3, 4, 5);

            decimal p = (3 + 4 + 5) / 2;
            decimal x = (p * (p - 3) * (p - 4) * (p - 5));

            Assert.AreEqual((decimal)Math.Sqrt((double)x), unknownFigure.CalculateArea());         

        }

        [TestMethod]
        public void UnknownFigure_CalculateAreaCircleTest()
        {            
            var radius = 2;

            Figure unknownFigure = new Circle(radius);

            var area = (decimal)Math.PI * radius * radius;

            Assert.AreEqual(area, unknownFigure.CalculateArea());                       

        }


    }
}
