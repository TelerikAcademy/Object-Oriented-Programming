using System;
using System.Collections.Generic;

public class ExtensionMethods
{
    public static void Main()
    {
        var str = "Hello Extension Methods";
        Console.WriteLine(str.WordCount());

        var ints = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine(ints.ToString());
        Console.WriteLine(ints.ToString<int>());

        ints.IncreaseWidth(5);
        Console.WriteLine(ints.ToString<int>());
    }
}
