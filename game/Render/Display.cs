namespace game.Render;

public sealed class Display
{
    private int _animationFrame;
    private readonly char[] _characters;

    public Display(char[] characters)
    {
        _characters = characters;
    }

    public char GetCharacter()
    {
        _animationFrame++;
        
        return _characters[_animationFrame % _characters.Length];
    }
}