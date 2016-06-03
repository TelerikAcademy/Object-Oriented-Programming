using System;

class FilledSquare : Square
{
    private Color Color { get; set; }

    public FilledSquare(float size, int x, int y, Color color)
        : base(size, x, y)
    {
        this.Color = color;
    }
}
