using System;

class FilledRectangle : Rectangle
{
    private Color Color { get; set; }

    public FilledRectangle(float width, float height, int x, int y, Color color)
        : base(width, height, x, y)
    {
        this.Color = color;
    }
}
