using game.Physics;
using game.Render;

namespace game.Objects;

public class StaticObject
{
    private readonly Position _position;

    public StaticObject(Position position)
    {
        _position = position;
    }
}