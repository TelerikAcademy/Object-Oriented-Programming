using System;

class ImplementingIEnumerable
{
	static void Main()
	{
		LinkedList<string> list =
			new LinkedList<string>("1st element",
			new LinkedList<string>("2nd element",
			new LinkedList<string>("3rd element")));
		foreach (var item in list)
		{
			Console.WriteLine(item);
		}
	}
}
