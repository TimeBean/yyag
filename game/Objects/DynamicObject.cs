using game.Physics;
using game.Render;

namespace game.Objects;

public class DynamicObject : IMoveable
{
    public Display Display { get; private set; }
    
    private Position _position;
    
    public DynamicObject(Position position, Display display)
    {
        _position = position;
        Display = display;
    }

    public DynamicObject(int x, int y, Display display) : this(new Position(x, y), display) { }

    public void Move(Position deltaPosition) => _position.Move(deltaPosition);
    public void Move(int deltaX, int deltaY) => Move(new Position(deltaX, deltaY));

    public Position Position => new Position(_position);
}