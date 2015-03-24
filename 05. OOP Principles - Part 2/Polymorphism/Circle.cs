using System;

public class Circle : Figure
{
    public double Radius { get; set; }

    public override double CalcSurface()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}
