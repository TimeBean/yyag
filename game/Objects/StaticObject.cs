using game.Physics;
using game.Render;

namespace game.Objects;

public class StaticObject
{
    public Display Display { get; private set; }
    
    private readonly Position _position;

    public StaticObject(Display display, Position position)
    {
        Display = display;
        _position = position;
    }
    
    public Position Position => new Position(_position);
}