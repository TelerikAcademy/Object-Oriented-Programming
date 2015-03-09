using System;

public class Circle : IShape, IMovable
{
    private int x, y, radius;

    public Circle(int x, int y, int radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public void SetPosition(int x, int y) // From IShape 
    {
        this.x = x;
        this.y = y;
    }

    public double CalculateSurface() // From IShape 
    {
        return Math.PI * radius * radius;
    }

    public void Move(int deltaX, int deltaY) // From IMovable 
    {
        this.x += deltaX;
        this.y += deltaY;
    }
}
