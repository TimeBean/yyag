using game.Physics;

namespace game.Objects;

public class DynamicObject : IMoveable
{
    private Position _position;

    public DynamicObject(Position position)
    {
        _position = position;
    }

    public DynamicObject(int x, int y) : this(new Position(x, y)) { }

    public void Move(Position deltaPosition) => _position.Move(deltaPosition);
    public void Move(int deltaX, int deltaY) => Move(new Position(deltaX, deltaY));

    public void SetPosition(Position position) => _position = position;
    public void SetPosition(int x, int y) => SetPosition(new Position(x, y));

    public Position Position => _position;
}