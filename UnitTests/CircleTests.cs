using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLibrary;

namespace UnitTests
{
    [TestClass]
    public class CircleTests
    {       
        [TestMethod]
        public void Circle_СalculateAreaTest()
        {
            var radius = 2;

            var circle = new Circle(radius);

            var area = (decimal)Math.PI * radius * radius;

            Assert.AreEqual(area, circle.CalculateArea());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Circle_BadDataTestZero()
        {
            var badCircle = new Circle(0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Circle_BadDataTestNegative()
        {
            var badCircle = new Circle(-1);
        }
    }
}
