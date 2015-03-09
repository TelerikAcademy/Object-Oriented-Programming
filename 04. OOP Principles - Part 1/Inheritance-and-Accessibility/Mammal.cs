using System;

public class Mammal : Creature
{
    public int Age { get; set; }

    public Mammal(string name, int age) : base(name)
    {
        this.Age = age;
    }

    public void Sleep()
    {
        Console.WriteLine("Shhh! {0} is sleeping!", this.Name);
    }
}
