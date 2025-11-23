namespace game.Physics;

public sealed class Position
{
    private int X { get; set; }
    private int Y { get; set; }
    
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }

    public void Move(Position position)
    {
        X = position.X;
        Y = position.Y;
    }

    public void Set(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Set(Position position)
    {
        X = position.X;
        Y = position.Y;
    }
}