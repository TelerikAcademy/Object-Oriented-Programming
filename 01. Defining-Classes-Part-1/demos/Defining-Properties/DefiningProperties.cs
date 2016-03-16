using System;

class PropertiesExample
{
	static void Main()
	{
		Rectangle firstRect = new Rectangle(5.0f, 2.3f);
		Console.WriteLine("Rectangle 1 is {0}x{1} and has area {2}", 
            firstRect.Height, firstRect.Width, firstRect.Area);

		Rectangle secondRect2 = new Rectangle(3.0f, 4.0f);
		Console.WriteLine("Rectangle 2 is {0}x{1} and has area {2}", 
            secondRect2.Height, secondRect2.Width, secondRect2.Area);

		// Can't set a value to readonly property!
		//secondRect.Area = 20.3f;

		Console.WriteLine();
		
		UserProfile profile = new UserProfile(91112, "Steve", "Balmer");
		Console.WriteLine(profile);

		// Can't assign a private set property!
		// profile.UserId = 12345;
	}
}
