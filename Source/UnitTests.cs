using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace UnitTesting
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TriangleWithWrongParameters()
        {
            double sideAB = 1.1;
            double sideBC = 2.1;
            double sideAC = 3.1;

            try
            {
                new Triangle(sideAB, sideBC, sideAC);
                Assert.Fail("Exception not thrown");
            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            double radius = 4.2;

            Circle circle = new Circle(radius);

            double checkedArea = Math.PI * Math.Pow(3, 2);
            double area = circle.GetArea();

            Assert.AreEqual(checkedArea, area);
        }

        [TestMethod]
        public void IsTriangleRight()
        {
            double sideAB = 3.0;
            double sideAC = 4.0;
            double sideBC = 5.0;

            Triangle triangle = new Triangle(sideAB, sideAC, sideBC);

            bool testResult = triangle.CheckRightTriangle();
            Assert.IsTrue(testResult);
        }
    }
}
