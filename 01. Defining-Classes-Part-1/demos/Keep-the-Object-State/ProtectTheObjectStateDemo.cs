using System;

public class ProtectTheObjectStateDemo
{
	static void Main()
	{
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();
		
		Console.Write("Enter your age: ");
		int age = int.Parse(Console.ReadLine());

		try
		{
			Person person = new Person(name, age);
			Console.WriteLine("Hello, {0}!", person.Name);
			Console.WriteLine("Your age is {0}.", person.Age);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Cannot create person object: " + ex);
		}
	}
}
