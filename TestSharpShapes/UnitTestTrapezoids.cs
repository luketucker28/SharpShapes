using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestTrapezoids
    {
        [TestMethod]
        public void TestTrapezoidConstructorSetsProperties()
        {
            Trapezoid trapezoid = new Trapezoid(8, 2, 4);
            Assert.AreEqual(8, trapezoid.LongBase);
            Assert.AreEqual(2, trapezoid.ShortBase);
            Assert.AreEqual(4, trapezoid.Height);
        }

        [TestMethod]
        public void TestTrapezoidConstructorSetsProperties2()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 2);
            Assert.AreEqual(20, trapezoid.LongBase);
            Assert.AreEqual(15, trapezoid.ShortBase);
            Assert.AreEqual(2, trapezoid.Height);
        }

        [TestMethod]
        public void TestTrapezoidConstructorCalculatesAngles1()
        {
            Trapezoid trapezoid = new Trapezoid(8, 4, 2);
            Assert.AreEqual(45, trapezoid.AcuteAngle);
            Assert.AreEqual(135, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestTrapezoidConstructorCalculatesAngles2()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 2);
            Assert.AreEqual((decimal) 38.66, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal) 141.34, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksBaseLengths()
        {
            new Trapezoid(15, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksLongBaseLength()
        {
            new Trapezoid(0, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidTrapezoidCantBeRectangle()
        {
            new Trapezoid(20, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksShortBaseLength()
        {
            new Trapezoid(15, 0, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksHeight()
        {
            new Trapezoid(15, 20, 0);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestRectangleConstructorSanityChecksWidthPositivity()
        //{
        //    Rectangle rectangle = new Rectangle(-1, 50);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestRectangleConstructorSanityChecksHeight()
        //{
        //    Rectangle rectangle = new Rectangle(50, 0);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestRectangleConstructorSanityChecksHeightPositivity()
        //{
        //    Rectangle rectangle = new Rectangle(50, -1);
        //}

        //[TestMethod]
        //public void TestScaleRectangle200Percent()
        //{
        //    Rectangle rectangle = new Rectangle(10, 15);
        //    rectangle.Scale(200);
        //    Assert.AreEqual(20, rectangle.Width);
        //    Assert.AreEqual(30, rectangle.Height);
        //}

        //[TestMethod]
        //public void TestScaleRectangle150Percent()
        //{
        //    Rectangle rectangle = new Rectangle(10, 15);
        //    rectangle.Scale(150);
        //    Assert.AreEqual(15, rectangle.Width);
        //    Assert.AreEqual((decimal)22.5, rectangle.Height);
        //}

        //[TestMethod]
        //public void TestScaleRectangle100Percent()
        //{
        //    Rectangle rectangle = new Rectangle(10, 15);
        //    rectangle.Scale(100);
        //    Assert.AreEqual(10, rectangle.Width);
        //    Assert.AreEqual(15, rectangle.Height);
        //}

        //[TestMethod]
        //public void TestScaleRectangle37Percent()
        //{
        //    Rectangle rectangle = new Rectangle(10, 15);
        //    rectangle.Scale(37);
        //    Assert.AreEqual((decimal)3.7, rectangle.Width);
        //    Assert.AreEqual((decimal)5.55, rectangle.Height);
        //}

        //[TestMethod]
        //public void TestScaleRectangleUpAndDown()
        //{
        //    Rectangle rectangle = new Rectangle(10, 15);
        //    rectangle.Scale(50);
        //    rectangle.Scale(200);
        //    Assert.AreEqual(10, rectangle.Width);
        //    Assert.AreEqual(15, rectangle.Height);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestScaleRectangleTo0Percent()
        //{
        //    Rectangle rectangle = new Rectangle(10, 15);
        //    rectangle.Scale(0);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestScaleRectangleToNegativePercent()
        //{
        //    Rectangle rectangle = new Rectangle(10, 15);
        //    rectangle.Scale(-5);
        //}

        //[TestMethod]
        //public void TestSidesCount()
        //{
        //    Rectangle rectangle = new Rectangle(1, 5);
        //    Assert.AreEqual(4, rectangle.SidesCount);
        //}

        //[TestMethod]
        //public void TestRectangleArea()
        //{
        //    Rectangle rectangle = new Rectangle(1, 5);
        //    Assert.AreEqual(5, rectangle.Area());
        //}

        //[TestMethod]
        //public void TestBiggerRectangleArea()
        //{
        //    Rectangle rectangle = new Rectangle(10, 100);
        //    Assert.AreEqual(1000, rectangle.Area());
        //}

        //[TestMethod]
        //public void TestRectanglePerimeter()
        //{
        //    Rectangle rectangle = new Rectangle(1, 5);
        //    Assert.AreEqual(12, rectangle.Perimeter());
        //}

        //[TestMethod]
        //public void TestBiggerRectanglePerimeter()
        //{
        //    Rectangle rectangle = new Rectangle(10, 100);
        //    Assert.AreEqual(220, rectangle.Perimeter());
        //}

        [TestMethod]
        public void TestTrapezoidSidesCount()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 2);
            Assert.AreEqual(4, trapezoid.SidesCount);
        }

        [TestMethod]
        public void TestDefaultTrapezoidColors()
        {
            Trapezoid shape = new Trapezoid(20, 15, 2);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
        }
    }
}
