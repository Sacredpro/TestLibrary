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
    public class CircleTests
    {
        public Triangle _rightTriangle;
        public Triangle _triangle;
        public Triangle _badTriangle;
     

        [TestInitialize]
        public void Init()
        {
        
            _rightTriangle = new Triangle(3,4,5);
            _triangle = new Triangle(2, 4, 5);
        }

        [TestMethod]
        public void Triangle_calculateAreaTest()
        {

            Assert.AreEqual(3.79, Math.Round(_triangle.calculateArea(),2));

            // ???
        }

        [TestMethod]
        public void Triangle_checkIfTriangleIsRightTest()
        {
            Assert.AreEqual(true, _rightTriangle.checkIfTriangleIsRight());
        }

        [TestMethod]
        public void Triangle_checkIfTriangleIsRightTest2()
        {
            Assert.AreEqual(false, _triangle.checkIfTriangleIsRight());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Triangle_BadDataTest()
        {
            _badTriangle = new Triangle(1,2,3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Triangle_BadDataTest2()
        {
            _badTriangle = new Triangle(0, 2, 3);
        }


    }
}
