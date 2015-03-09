using System;

public class Dog : Mammal
{
    public string Breed { get; private set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.Breed = breed;
    }

    internal void WagTail()
    {
        Console.WriteLine("{0} is {1} wagging his {2}-aged tail ...",
            this.Name, this.Breed, this.Age);
        //this.Walk(); // This will successfully compile - Walk() is protected
        //this.Talk(); // This will not compile - Talk() is private
        //this.Name = "Doggy"; // This will not compile - Name.set is private
    }
}
