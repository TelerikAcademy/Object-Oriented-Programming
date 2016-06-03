using System;

abstract class Shape
{
    protected Point Position { get; set; }

    public Shape(Point position)
    {
        this.Position = position;
    }
}

