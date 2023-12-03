using NUnit.Framework;
using SecondTryLIB.Models;

namespace SecondTryLIB.Tests.TriangleTests
{
    [TestFixture]
    public class TrianglePropertyTests
    {
        [Test]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            bool isRight = triangle.IsRightAngled();
            Console.WriteLine($"Тест на прямоугольный треугольник (3, 4, 5): Результат = {isRight}");
            Assert.IsTrue(isRight);
        }

        [Test]
        public void IsRightAngled_NotRightAngledTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(3, 3, 3);
            bool isRight = triangle.IsRightAngled();
            Console.WriteLine($"Тест на прямоугольный треугольник (3, 3, 3): Результат = {isRight}");
            Assert.IsFalse(isRight);
        }
    }
}
