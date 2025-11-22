using game.Physics;
using game.Render;

namespace game.Objects;

public interface IGameObject
{
    public Position Position { get; set; } 
    public Display Display { get; set; }
}