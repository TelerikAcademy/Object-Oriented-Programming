public class Square : Figure
{
    public double Size { get; set; }

    public override double CalcSurface()
    {
        return this.Size * this.Size;
    }
}
