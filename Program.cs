using BridgePatternApp.Enums;
using BridgePatternApp.Helpers;
using ShapeColorBridgeApp.Abstractions;
using ShapeColorBridgeApp.Implementations;

namespace ShapeColorBridgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = ShapeFactory.CreateShape(ShapeType.Circle, ColorType.Red);
            Shape redSquare = ShapeFactory.CreateShape(ShapeType.Square, ColorType.Red);
            Shape redTriangle = ShapeFactory.CreateShape(ShapeType.Triangle, ColorType.Red);
            Shape redRectangle = ShapeFactory.CreateShape(ShapeType.Rectangle, ColorType.Red);

            Shape blueCircle = ShapeFactory.CreateShape(ShapeType.Circle, ColorType.Blue);
            Shape blueSquare = ShapeFactory.CreateShape(ShapeType.Square, ColorType.Blue);
            Shape blueTriangle = ShapeFactory.CreateShape(ShapeType.Triangle, ColorType.Blue);
            Shape blueRectangle = ShapeFactory.CreateShape(ShapeType.Rectangle, ColorType.Blue);


            Shape greenCircle = ShapeFactory.CreateShape(ShapeType.Circle, ColorType.Green);
            Shape greenSquare = ShapeFactory.CreateShape(ShapeType.Square, ColorType.Green);
            Shape greenTriangle = ShapeFactory.CreateShape(ShapeType.Triangle, ColorType.Green);
            Shape greenRectangle = ShapeFactory.CreateShape(ShapeType.Rectangle, ColorType.Green);


            Console.ForegroundColor = ConsoleColor.Red;
            redCircle.Draw();
            redSquare.Draw();
            redTriangle.Draw();
            redRectangle.Draw();

            Console.ForegroundColor = ConsoleColor.Blue;
            blueCircle.Draw();
            blueSquare.Draw();
            blueTriangle.Draw();
            blueRectangle.Draw();

            Console.ForegroundColor = ConsoleColor.Green;
            greenCircle.Draw();
            greenSquare.Draw();
            greenTriangle.Draw();
            greenRectangle.Draw();

            Console.ReadLine();
        }
    }
}
