using ShapeColorBridgeApp.Implementations;

namespace ShapeColorBridgeApp.Abstractions
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle in {color.ApplyColor()}");
        }
    }
}
