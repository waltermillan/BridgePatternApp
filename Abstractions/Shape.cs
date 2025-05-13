using ShapeColorBridgeApp.Implementations;

namespace ShapeColorBridgeApp.Abstractions
{
    /*
        Bridge: Is a structural design pattern that allows you to split a large class, or a group of closely related classes, 
        into two separate hierarchies (abstraction and implementation) that can be developed independently of each other.
     
        Shape
        Abstract class representing a shape, associated to a color (IColor).

        Circle, Square, Triangle, Rectangle
        Inherit from Shape and define how that shape is drawn with the assigned color.
    */
    public abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Draw();
    }
}
