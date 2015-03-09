using System;

delegate int StringDelegate<T>(T value); 

public class MultiDelegates
{
	static int PrintString(string str)
	{
		Console.WriteLine("Str: {0}", str);
		return 1;
	}

	int PrintStringLength(string value)
	{
		Console.WriteLine("Length: {0}", value.Length);
		return 2;
	}

	public static void Main()
	{
		StringDelegate<string> d = MultiDelegates.PrintString;
		MultiDelegates instance = new MultiDelegates();
		d += instance.PrintStringLength;
		d += delegate(string str)
		{
			Console.WriteLine("Uppercase: {0}", str.ToUpper());
			return 3;
		};
		int result = d("some string value");
		Console.WriteLine("Returned result: {0}", result);

        Func<string, int> predefinedIntParse = int.Parse;
        Action<object> predefinedAction = Console.WriteLine;

        int number = predefinedIntParse("10");
        Console.WriteLine(number);

        predefinedAction(1000);
	}
}
