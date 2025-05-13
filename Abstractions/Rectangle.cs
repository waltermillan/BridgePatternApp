using ShapeColorBridgeApp.Abstractions;
using ShapeColorBridgeApp.Implementations;

namespace BridgePatternApp.Abstractions
{
    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle in {color.ApplyColor()}");
        }
    }
}
