using NUnit.Framework;
using SecondTryLIB.Models;
using System;

namespace SecondTryLIB.Tests.CircleTests
{
    [TestFixture]
    public class CircleAreaTests
    {
        [TestCase(1, Math.PI)]
        [TestCase(2, Math.PI * 4)]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            var area = circle.CalculateArea();
            Console.WriteLine($"Тест вычисления площади круга: Ожидаемая площадь = {expectedArea}, Полученная площадь = {area}");
            Assert.AreEqual(expectedArea, area, 1e-6);
        }
        [Test]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            var area = circle.CalculateArea();
            Assert.AreEqual(Math.PI * 25, area, 1e-6);
        }

        [Test]
        public void Circle_InvalidRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }



    }

}
