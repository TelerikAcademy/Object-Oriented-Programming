using System;

public class Creature
{
    protected string Name { get; private set; }

    public Creature(string name)
    {
        this.Name = name;
    }

    private void Talk()
    {
        Console.WriteLine("I am creature ...");
    }

    protected void Walk()
    {
        Console.WriteLine("Walking, walking, walking ....");
    }
}
