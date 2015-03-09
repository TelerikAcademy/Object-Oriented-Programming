using System;

public class Cheetah : Animal
{
    public override int Speed
    {
        get
        {
            return 100;
        }
    }

    public override string GetName()
    {
        return "cheetah";
    }
}
