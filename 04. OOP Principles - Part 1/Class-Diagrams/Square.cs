using System;

class Square : Shape, ISufraceCalculatable
{
    private float Size { get; set; }

    public Square(float size, int x, int y)
        : base (new Point(x,y))
    {
        this.Size = size;
    }

    public float CalculateSurface()
    {
        return this.Size * this.Size;
    }
}
