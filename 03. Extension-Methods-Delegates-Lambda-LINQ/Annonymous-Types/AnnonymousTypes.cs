using System;

class AnnonymousTypes
{
    static void Main()
    {
        var myCar =
            new { Color = "Red", Brand = "BMW", Speed = 180 };
        Console.WriteLine("My car is a {0} {1}.",
            myCar.Color, myCar.Brand);
        Console.WriteLine("It runs {0} km/h.", myCar.Speed);

        Console.WriteLine();

        var p = new { X = 3, Y = 5 };
        var q = new { X = 3, Y = 5 };
        Console.WriteLine(p);
        Console.WriteLine(q);
        Console.WriteLine(p == q); // false
        Console.WriteLine(p.Equals(q)); // true

        Console.WriteLine();

        var combined = new { P = p, Q = q };
        Console.WriteLine(combined.P.X);

        Console.WriteLine();

        var arr = new[]
		{
			new { X = 3, Y = 5 },
            new { X = 1, Y = 2 }, 
			new { X = 0, Y = 7 } 
		};
        foreach (var item in arr)
        {
            Console.WriteLine("({0}, {1})", item.X, item.Y);
        }
	}
}
