using System;
using System.Collections.Generic;
using System.Linq;

class LambdaExpressions
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4 };
        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
        foreach (var num in evenNumbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        // 2 4

        Console.WriteLine();

        list.RemoveAll(x => x > 3);
        foreach (var num in list)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        // 1 2 3

        Console.WriteLine();

        var pets = new Pet[]
        { 
          new Pet { Name="Sharo", Age=8 }, 
          new Pet { Name="Rex", Age=4 },
          new Pet { Name="Strela", Age=1 },
          new Pet { Name="Bora", Age=3 }
        };
        var sortedPets = pets.OrderBy(pet => pet.Age);
        foreach (Pet pet in sortedPets)
        {
            Console.WriteLine("{0} -> {1}",
              pet.Name, pet.Age);
        }

        Console.WriteLine();

        list = new List<int>()
            { 20, 1, 4, 8, 9, 44 };

        // Process each argument with code statements
        evenNumbers = list.FindAll((i) =>
            {
    	        Console.WriteLine("value of i is: {0}", i);
    	        return (i % 2) == 0;
            });

        Console.WriteLine("Here are your even numbers:");
        foreach (int even in evenNumbers)
            Console.Write("{0} ", even);

        Console.WriteLine();
        Console.WriteLine();

        Func<bool> boolFunc = () => true;
        Func<int, bool> intFunc = (x) => x < 10;
        if (boolFunc() && intFunc(5))
        {
            Console.WriteLine("5 < 10");
        }

		List<string> towns = new List<string>()
		{ 
		  "Sofia", "Plovdiv", "Varna", "Sopot", "Silistra" 
		};

		List<string> townsWithS =
		  towns.FindAll(delegate(string town)
		  {
			  return town.StartsWith("S");
		  });

		// A short form of the above (with lambda expression)
		//List<string> townsWithS = towns.FindAll((town) => town.StartsWith("S"));

		foreach (string town in townsWithS)
		{
			Console.WriteLine(town);
		}
    }
}
