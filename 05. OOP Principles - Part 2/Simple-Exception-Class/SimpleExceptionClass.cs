using System;
using System.Globalization;

class SimpleExceptionClass
{
	static double CalcSize(object obj)
	{
		// To use the class Figure first add a reference to the project where it is defined!
		if (obj is Figure)
		{
			return ((Figure)obj).CalcSurface();
		}
		if (obj is string)
		{
			return ((string)obj).Length;
		}
		try
		{
			return (double)(dynamic)obj;
		}
		catch (Exception ex)
		{
			throw new InvalidCalculationException(
				"Cannot calculate the size of the specified object", ex);
		}
	}

	static void Main()
	{
		Console.WriteLine(CalcSize(new Rectangle() { Width = 3.3, Height = 5.2 }));
		Console.WriteLine(CalcSize(new Circle() { Radius = 1.5 }));
		Console.WriteLine(CalcSize("Hello"));
		Console.WriteLine(CalcSize(42));
		Console.WriteLine(CalcSize(1.55));
		Console.WriteLine(CalcSize(DateTime.Now));
	}
}
