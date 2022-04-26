using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLibrary;

namespace UnitTests
{
        [TestClass]
        public class TriangleTests
        {
        public Circle _circle;
        public Circle _badCircle;
            

            [TestInitialize]
            public void Init()
            {
           
            _circle = new Circle(2);
            }

            [TestMethod]
            public void Circle_calculateAreaTest()
            {
                Assert.AreEqual(12.56, _circle.calculateArea());
            }

            [TestMethod]
            [ExpectedException(typeof(Exception))]
        public void Circle_BadDataTest()
            {
            _badCircle = new Circle(0);

              
            }
        
    }
}
