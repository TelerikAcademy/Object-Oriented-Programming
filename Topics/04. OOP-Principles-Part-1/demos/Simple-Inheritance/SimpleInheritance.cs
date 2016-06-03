using System;

class SimpleInheritance
{
    static void Main()
    {
        Dog joe = new Dog(8, "Labrador");
		joe.Sleep();
		joe.WagTail();
		Console.WriteLine("Joe is {0} years old dog of breed {1}.",
			joe.Age, joe.Breed);

		Console.WriteLine();

		Cat dolly = new Cat(3);
		dolly.Sleep();
		dolly.SayMyaau();
		Console.WriteLine("Dolly is {0} years old cat.", dolly.Age);
	}
}
