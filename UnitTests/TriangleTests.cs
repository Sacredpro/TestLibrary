using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLibrary;

namespace UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        private Triangle _rightTriangle;
        private Triangle _triangle;    
     

        [TestInitialize]
        public void Init()
        {        
            _rightTriangle = new Triangle(3,4,5);
            _triangle = new Triangle(2, 4, 5);
        }

        [TestMethod]
        public void Triangle_CalculateAreaTest()
        {
            decimal p = (3 + 4 + 5) / 2;
            decimal x = (p * (p - 3) * (p - 4) * (p - 5));

            Assert.AreEqual((decimal)Math.Sqrt((double)x), _rightTriangle.CalculateArea());
        }

        [TestMethod]
        public void Triangle_CheckIsRightTest()
        {
            Assert.AreEqual(true, _rightTriangle.СheckIsRight());
        }

        [TestMethod]
        public void Triangle_CheckIsRightTestNotRight()
        {
            Assert.AreEqual(false, _triangle.СheckIsRight());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Triangle_BadDataTestWrongSides()
        {
            Triangle badTriangle = new Triangle(1,2,3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Triangle_BadDataTestZero()
        {
            Triangle badTriangle = new Triangle(0, 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Triangle_BadDataTestNegative()
        {
            Triangle badTriangle = new Triangle(-1,-2,-3);
        }


    }
}
