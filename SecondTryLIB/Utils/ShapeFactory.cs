using SecondTryLIB.Interfaces;
using SecondTryLIB.Models;

public static class ShapeFactory
{
    public static IShape CreateShape(string shapeType, params double[] args)
    {
        switch (shapeType.ToLower())
        {
            case "circle":
                return new Circle(args[0]);
            case "triangle":
                return new Triangle(args[0], args[1], args[2]);
            default:
                throw new ArgumentException("Invalid type");
        }
    }
}
