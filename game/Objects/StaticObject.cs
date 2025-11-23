using game.Physics;
using game.Render;

namespace game.Objects;

public class StaticObject
{
    private readonly Position _position;
    private readonly Display _display;

    protected StaticObject(Position position, Display display)
    {
        _position = position;
        _display = display;
    }
}