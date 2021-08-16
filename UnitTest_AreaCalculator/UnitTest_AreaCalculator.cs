using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;


namespace UnitTest_AreaCalculator
{
    [TestClass]
    public class AreaCalculatorTest
    {
        [TestMethod]
        public void CalculateCircleArea()
        {
            double radius = 13;
            double expected = 530.93;

            Circle circle = new Circle(radius);

            double actual = Math.Round(circle.CalculateArea(), 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTriangleArea()
        {
            double a = 3, b = 5, c = 7;
            double expected = 6.5;

            Triangle trg = new Triangle(a, b, c);

            double actual = Math.Round(trg.CalculateArea(), 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRiangleRight_false()
        {
            double a = 3, b = 5, c = 7;
            bool expected = false;

            Triangle trg = new Triangle(a, b, c);

            bool actual = trg.IsTriangleRight();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRiangleRight_true()
        {
            double a = 6, b = 8, c = 10;
            bool expected = true;

            Triangle trg = new Triangle(a, b, c);

            bool actual = trg.IsTriangleRight();

            Assert.AreEqual(expected, actual);
        }
    }
}
