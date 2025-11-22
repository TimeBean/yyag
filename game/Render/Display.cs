namespace game.Render;

public sealed class Display(char[] characters)
{
    private int _animationFrame;

    public char GetCharacter()
    {
        _animationFrame++;
        return characters[_animationFrame % characters.Length];
    }
}