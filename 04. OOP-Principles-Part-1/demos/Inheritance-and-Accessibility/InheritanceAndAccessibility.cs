using System;

class InheritanceAndAccessibility
{
    static void Main()
    {
        Dog joe = new Dog("Sharo", 6, "labrador");
        joe.Sleep(); // Sleep() is public
        Console.WriteLine("Breed: " + joe.Breed);
		joe.WagTail(); // WagTail() is internal

        //joe.Talk(); // This will not compile - Talk() is private
        //joe.Walk(); // This will not compile - Walk() is protected
        //Console.WriteLine("Name: " + joe.Name); // Name is protected property
    }
}
