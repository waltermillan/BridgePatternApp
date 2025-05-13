using ShapeColorBridgeApp.Implementations;

namespace ShapeColorBridgeApp.Abstractions
{
    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a triangle in {color.ApplyColor()}");
        }
    }
}
