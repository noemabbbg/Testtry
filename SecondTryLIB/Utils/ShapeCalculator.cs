using SecondTryLIB.Interfaces;

namespace SecondTryLIB.Utils
{
    public class ShapeCalculator
    {
        
        public double CalculateArea(string shapeType, params double[] args)
        {
            var shape = ShapeFactory.CreateShape(shapeType, args);
            return shape.CalculateArea();
        }

    }
}