using System;

class GenericListExample
{
	static void Main()
	{
		// Declare a list of type int 
		GenericList<int> intList = new GenericList<int>();
		intList.Add(1);
		intList.Add(2);
		intList.Add(3);
		Console.WriteLine("Number of elements: {0}", intList.Count);
		for (int i = 0; i < intList.Count; i++)
		{
			int element = intList[i];
			Console.WriteLine(element);
		}

		Console.WriteLine();

		// Declare a list of type string
		GenericList<string> stringList = new GenericList<string>();
		stringList.Add("C#");
		stringList.Add("Java");
		stringList.Add("PHP");
		stringList.Add("SQL");
		Console.WriteLine("Number of elements: {0}", stringList.Count);
		for (int i = 0; i < stringList.Count; i++)
		{
			string element = stringList[i];
			Console.WriteLine(element);
		}
	}
}
