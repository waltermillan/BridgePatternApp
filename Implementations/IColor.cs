namespace ShapeColorBridgeApp.Implementations
{
    /*
        Interface that defines how to apply a color to a shape.

        Red, Green, Blue
        Implement IColor, returning the name of the corresponding color.
    */

    public interface IColor
    {
        string ApplyColor();
    }

}
