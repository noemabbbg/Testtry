using NUnit.Framework;
using SecondTryLIB.Models;
using System;

namespace SecondTryLIB.Tests.TriangleTests
{
    [TestFixture]
    public class TriangleAreaTests
    {
        [TestCase(3, 4, 5, 6)]
        [TestCase(6, 8, 10, 24)]
        public void CalculateArea_ValidSides_ReturnsCorrectArea(double sideA, double sideB, double sideC, double expectedArea)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var area = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, area, 1E-6);
        }

        [Test]
        public void CalculateArea_ZeroSidedTriangle_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
        }
    }
}
