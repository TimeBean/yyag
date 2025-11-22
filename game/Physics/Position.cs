namespace game.Physics;

public sealed class Position
{
    private int X { get; set; }
    private int Y { get; set; }
    
    public void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }
}