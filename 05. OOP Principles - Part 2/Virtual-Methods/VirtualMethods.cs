using System;

internal static class VirtualMethods
{
    private static void Main()
    {
        Figure[] figures =
            {
                new Line(),
                new Circle(),
                new Line(),
                new SpecialFigure(),
                new Line(),
            };
        foreach (var f in figures)
        {
            f.Draw();
            Console.WriteLine();
        }
    }
}
