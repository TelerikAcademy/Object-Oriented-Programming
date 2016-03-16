using System;
using System.Dynamic;

class DynamicTypesExample
{
	static void Main()
	{
		dynamic a = 5;
		dynamic b = 7.5;
		dynamic sum = a + b;
		Console.WriteLine(sum); // 12.5

		dynamic s = "Pesho";
		dynamic newSum = sum + s;
		Console.WriteLine(newSum); // 12.5Pesho

		// This will cause runtime error
		//dynamic val = sum . s; // "." (dot) operator
		//Console.WriteLine(val); 

		dynamic d = new { X = 5, Y = 7 };
		dynamic x = d . X;
		Console.WriteLine(x);

		dynamic square = 
			(Func<int, int>) (p => p * p);
		int x2 = square(x);
		Console.WriteLine(x2);

		dynamic n = null;
		int? nullSum = x2 + n; // null
		Console.WriteLine(nullSum);

		dynamic obj = new ExpandoObject();
		obj.Size = 5;
		obj.Sum = (Func<int, int, int>)
			((p1,p2) => p1 + p2);

		Console.WriteLine(obj.Sum(3, obj.Size));
	}
}
