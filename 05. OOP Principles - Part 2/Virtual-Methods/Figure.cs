using System;

abstract class Figure
{
	public virtual void Draw()
	{
		Console.WriteLine("I am a figure of unknown kind:");
		Console.WriteLine(this.GetType().Name);
	}
}
