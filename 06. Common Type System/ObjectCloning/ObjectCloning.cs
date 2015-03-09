using System;

class ObjectCloning
{
    static void Main()
    {
		LinkedList<string> initialList =
			new LinkedList<string>("Old fellow John",
			new LinkedList<string>("Granny Yaga",
			new LinkedList<string>("King Kiro")));

		LinkedList<string> deeplyClonedList = initialList.Clone();
		deeplyClonedList.Value = "1st changed";
		deeplyClonedList.NextNode.Value = "2nd changed";

		Console.WriteLine("initial list = {0}", initialList);
		Console.WriteLine("deeply cloned list = {0}", deeplyClonedList);

		Console.WriteLine();

		initialList =
			new LinkedList<string>("Old fellow John",
			new LinkedList<string>("Granny Yaga",
			new LinkedList<string>("King Kiro")));

		LinkedList<string> shallowCopy = initialList.ShallowCopy();
		shallowCopy.Value = "1st changed";
		shallowCopy.NextNode.Value = "2nd changed";

		Console.WriteLine("initial list = {0}", initialList);
		Console.WriteLine("shallow cloned list = {0}", shallowCopy);

		Console.WriteLine();

		initialList =
			new LinkedList<string>("Old fellow John",
			new LinkedList<string>("Granny Yaga",
			new LinkedList<string>("King Kiro")));

		LinkedList<string> memberwiseCopy = initialList.MemberwiseCopy();
		memberwiseCopy.Value = "1st changed";
		memberwiseCopy.NextNode.Value = "2nd changed";

		Console.WriteLine("initial list = {0}", initialList);
		Console.WriteLine("memberwise cloned list = {0}", memberwiseCopy);
	}
}
