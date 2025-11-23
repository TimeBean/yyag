namespace game.Physics;

public interface IMoveable
{
    Position Position { get; }
    
    public void Move(Position deltaPosition);
    public void Move(int deltaX, int deltaY);
    public void SetPosition(Position position);
    public void SetPosition(int x, int y);
}