using BridgePatternApp.Abstractions;
using BridgePatternApp.Enums;
using ShapeColorBridgeApp.Abstractions;
using ShapeColorBridgeApp.Implementations;
using System;

namespace BridgePatternApp.Helpers
{
    /*
        ShapeFactory
        Creates instances of shapes (Shape) with a color (IColor), using enums as input.
    */
    public static class ShapeFactory
    {
        public static Shape CreateShape(ShapeType shapeType, ColorType colorType)
        {
            IColor color = colorType switch
            {
                ColorType.Red => new Red(),
                ColorType.Green => new Green(),
                ColorType.Blue => new Blue(),
                _ => throw new ArgumentException("Invalid color")
            };

            return shapeType switch
            {
                ShapeType.Circle => new Circle(color),
                ShapeType.Square => new Square(color),
                ShapeType.Triangle => new Triangle(color),
                ShapeType.Rectangle => new Rectangle(color),
                _ => throw new ArgumentException("Invalid shape")
            };
        }
    }
}
