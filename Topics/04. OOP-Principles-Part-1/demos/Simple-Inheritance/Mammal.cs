using System;

public class Mammal
{
    public int Age { get; set; }

    public Mammal(int age)
    {
        this.Age = age;
    }
    
    public void Sleep()
    {
        Console.WriteLine("Shhh! I'm sleeping!");
    }
}
