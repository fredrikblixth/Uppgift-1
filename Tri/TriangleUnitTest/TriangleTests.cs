using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleUnitTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void isIsosceles()
        {
            // Isosceles triangle
            var triangle1 = new Triangle(3.0, 6.0, 3.0);

            // Not isosceles triangle
            var triangle2 = new Triangle(3.0, 4.0, 5.0);

            Assert.IsTrue(triangle1.isIsosceles());
            Assert.IsFalse(triangle2.isIsosceles());
        }

        [TestMethod]
        public void isEquilateral()
        {
            // Not Equilateral triangle
            var triangle1 = new Triangle(3.0, 6.0, 3.0);

            // Not Equilateral triangle
            var triangle2 = new Triangle(3.0, 4.0, 5.0);

            // Equilateral triangle
            var triangle3 = new Triangle(3.0, 3.0, 3.0);

            Assert.IsFalse(triangle1.isEquilateral());
            Assert.IsFalse(triangle2.isEquilateral());
            Assert.IsTrue(triangle3.isEquilateral());
        }

        [TestMethod]
        public void isScalene()
        {
            // Not scalene triangle
            var triangle1 = new Triangle(2.0, 2.0, 2.0);
            var triangle2 = new Triangle(2.0, 3.0, 2.0);

            // Scalene triangle
            var triangle3 = new Triangle(3.0, 5.0, 10.0);

            Assert.IsFalse(triangle1.isScalene());
            Assert.IsFalse(triangle2.isScalene());
            Assert.IsTrue(triangle3.isScalene());
        }

        [TestMethod]
        public void Triangle()
        {
            // Constructor with 3 doubles
            var array = new double[3] {10.0,15.5,20.1};
            var triangle1 = new Triangle(array);

            Assert.IsFalse(triangle1.isEquilateral());
            Assert.IsTrue(triangle1.isScalene());
            Assert.IsFalse(triangle1.isIsosceles());

            // Constructor with 3 points

            var point1 = new Point(0, 0);
            var point2 = new Point(-3, 0);
            var point3 = new Point(0, 3);

            var triangle2 = new Triangle(point1, point2, point3);

            Assert.IsTrue(triangle2.isIsosceles());
            Assert.IsFalse(triangle2.isScalene());
            Assert.IsFalse(triangle2.isEquilateral());

            var pointArray = new Point[3] {point1,point2,point3};

            var triangle3 = new Triangle(pointArray);

            Assert.IsTrue(triangle3.isIsosceles());
            Assert.IsFalse(triangle3.isScalene());
            Assert.IsFalse(triangle3.isEquilateral());
        }
    }
}
