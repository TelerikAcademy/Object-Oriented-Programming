using System;

public class Line : Figure
{
    public override void Draw()
    {
        Console.WriteLine("I am a line:");
        Console.WriteLine("-----");
    }

    public override void Important()
    {
        throw new NotImplementedException();
    }
}
