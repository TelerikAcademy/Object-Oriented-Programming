using System;

public class Point
{
	private int xCoord;
	private int yCoord;

	public Point(int xCoord, int yCoord)
	{
		this.xCoord = xCoord;
		this.yCoord = yCoord;
	}

	public double CalcDistance(Point p)
	{
		return Math.Sqrt(
		  (p.xCoord - this.xCoord) * (p.xCoord - this.xCoord) +
		  (p.yCoord - this.yCoord) * (p.yCoord - this.yCoord));
	}
}

class TestMethods
{
	static void Main()
	{
		Point p1 = new Point(2, 3);
		Point p2 = new Point(3, 4);
		System.Console.WriteLine(p1.CalcDistance(p2));
	}
}
