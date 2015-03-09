using System;

class NullableTypes
{
	static void Main()
	{
		int? x = 5;
		Console.WriteLine(x);

		x = 55;
		Console.WriteLine(x);

		//int i = x; // This will NOT compile
		int i = x.Value;
		Console.WriteLine(i);

		x = null;
		Console.WriteLine(x);

		//i = x.Value; // InvalidOperationException
		//Console.WriteLine(i);

		int y = 20;

		int? sum = x + y;
		Console.WriteLine(sum);

		int intSum = x.GetValueOrDefault() + y;
		Console.WriteLine(intSum);
	}
}
