using System;
using System.Linq;

class LINQQueries
{
    static void Main()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var querySmallNums =
            from num in numbers
            where num < 5
            select num;

        foreach (var num in querySmallNums)
        {
            Console.Write(num.ToString() + " ");
        }
        // The result is 4 1 3 2 0
        Console.WriteLine();
        Console.WriteLine();

        string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };

        var townPairs =
          from t1 in towns
              from t2 in towns
              select new { T1 = t1, T2 = t2 };

        foreach (var townPair in townPairs)
        {
            Console.WriteLine(townPair);
        }

        Console.WriteLine();

        string[] fruits = { "cherry", "apple", "blueberry", "banana" };

        // Sort in ascending sort
        var fruitsAscending =
            from fruit in fruits
            orderby fruit
            select fruit;

        foreach (string fruit in fruitsAscending)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine();
    }
}
