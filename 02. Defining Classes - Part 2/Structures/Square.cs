public struct Square
{
	public Point Location { get; set; }
	public int Size { get; set; }
	public Color SurfaceColor { get; set; }
	public Color BorderColor { get; set; }
	public Edges Edges { get; set; }

	public Square(Point location, int size, Color surfaceColor,
		Color borderColor, Edges edges)	: this()
	{
		this.Location = location;
		this.Size = size;
		this.SurfaceColor = surfaceColor;
		this.BorderColor = borderColor;
		this.Edges = edges;
	}

	public override string ToString()
	{
		string squareAsString = string.Format(
			"Rect[location({0},{1}), size({2}), edges({3}), " +
			"surface(#{4:X2}{5:X2}{6:X2}), border(#{7:X2}{8:X2}{9:X2})]",
			this.Location.X, this.Location.Y, this.Size, this.Edges,
			this.SurfaceColor.RedValue, this.SurfaceColor.GreenValue,
			this.SurfaceColor.BlueValue, this.BorderColor.RedValue,
			this.BorderColor.GreenValue, this.BorderColor.BlueValue);
		return squareAsString;
	}
}
