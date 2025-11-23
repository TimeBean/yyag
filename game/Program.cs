using game.Objects;
using game.Physics;
using game.Render;

namespace game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StaticObject staticObject = new StaticObject(new Display(['@']), new Position(1, 5));
            Console.WriteLine(staticObject.Display.GetCharacter());
        }
    }
}