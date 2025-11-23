namespace game.Physics;

public interface IMoveable
{
    Position Position { get; }
    
    public void Move(Position deltaPosition);
    public void Move(int deltaX, int deltaY);
}