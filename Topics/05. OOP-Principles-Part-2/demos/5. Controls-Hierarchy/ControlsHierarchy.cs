using System;
using System.Collections.Generic;

public static class ControlsHierarchy
{
    static void Main(string[] args)
    {
        IControl button1 = new Button();
        IControl button2 = new Button();
        IControl button3 = new Button();
        IControl button4 = new Button();

        List<IControl> buttonsInContainer = new List<IControl>();
        buttonsInContainer.Add(button1);
        buttonsInContainer.Add(button2);

        IControl container = new Container(buttonsInContainer);

        List<IControl> controlsInInnerSurface = new List<IControl>();
        controlsInInnerSurface.Add(button3);
        controlsInInnerSurface.Add(container);

        IControl innerSurface = new Surface(controlsInInnerSurface);

        List<IControl> controlsInOuterSurface = new List<IControl>();
        controlsInOuterSurface.Add(innerSurface);
        controlsInOuterSurface.Add(button4);

        IControl outerSurface = new Surface(controlsInOuterSurface);

        Console.WriteLine(outerSurface.Size);
    }
}