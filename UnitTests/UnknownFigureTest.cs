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
    public class UnknownFigureTest
    {
        public Figure _unknownFigure1;
        public Figure _unknownFigure2;

        [TestInitialize]
        public void Init()
        {            
            _unknownFigure1 = new Triangle(2, 4, 5);
            _unknownFigure2 = new Circle(2);
        }

        [TestMethod]
        public void unknownFigure_calculateAreaTest1()
        {

            Assert.AreEqual(3.8, Math.Round(_unknownFigure1.calculateArea(), 2));

            // ???

        }

        [TestMethod]
        public void unknownFigure_calculateAreaTest2()
        {

            Assert.AreEqual(12.56, _unknownFigure2.calculateArea());                      

        }

        
    }
}
