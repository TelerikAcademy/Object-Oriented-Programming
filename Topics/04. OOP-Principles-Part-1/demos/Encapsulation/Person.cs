using System;

class Person
{
	private string name;
	private int age;

	public string Name
	{
		get 
		{
			return this.name;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentException("Invalid person name.");
			}
			this.name = value;
		}
	}

	public int Age
	{
		get 
		{
			return this.age;
		}
		set
		{
			if (value < 0 || value > 120)
			{
				throw new ArgumentOutOfRangeException("Invalid person age.");
			}
			this.age = value;
		}
	}

	public Person(string name, int age)
	{
		this.Name = name;
		this.Age = age;
	}

	public override string ToString()
	{
		return string.Format("Person(name={0}, age={1})",
			this.name, this.age);
	}

	static void Main()
	{
		Person p = new Person("Bay Ivan", 73);
		Console.WriteLine(p);
	}
}
