using game.Physics;
using game.Render;

namespace game.Objects;

public class StaticGameObject : IGameObject
{
    public Position Position { get; set; }
    public Display Display { get; set; }
    
    public StaticGameObject(Position position, Display display)
    {
        Position = position;
        Display = display;
    }
}