using System;

class VirtualMethods
{
	static void Main()
	{
		Figure[] figures = new Figure[]
		{
			new Line(),
			new Circle(),
			new Line(),
			new SpecialFigure(),
			new Line(),
		};
		foreach (var f in figures)
		{
			f.Draw();
			Console.WriteLine();
		}
	}
}
