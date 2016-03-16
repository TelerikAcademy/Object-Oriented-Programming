using System;

public class Cat : Mammal
{
    public Cat(int age) : base(age)
    {
    }

    public void SayMyaau()
    {
        Console.WriteLine("Myaau...");
    }
}
