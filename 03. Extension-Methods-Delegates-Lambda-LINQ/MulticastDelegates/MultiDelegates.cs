using System;

public delegate int StringDelegate<T>(T value);

public class Program
{
    public static void Main()
    {
        StringDelegate<string> d = Program.PrintString;
        Program instance = new Program();
        d += instance.PrintStringLength;
        d += delegate(string str)
            {
                Console.WriteLine("Uppercase: {0}", str.ToUpper());
                return 3;
            };

        int result = d("some string value");
        Console.WriteLine("Returned result: {0}", result);

        Func<string, int> predefinedIntParse = int.Parse;
        int number = predefinedIntParse("10");
        Console.WriteLine(number);

        Action<object> predefinedAction = Console.WriteLine;
        predefinedAction(1000);
    }

    private static int PrintString(string str)
    {
        Console.WriteLine("Str: {0}", str);
        return 1;
    }

    private int PrintStringLength(string value)
    {
        Console.WriteLine("Length: {0}", value.Length);
        return 2;
    }
}
