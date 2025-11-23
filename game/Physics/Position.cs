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

    public Position(Position other) : this(other.X, other.Y) { }
        
    public void Move(Position position)
    {
        X = position.X;
        Y = position.Y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}