public class Person
{
	private string name;
	private int age;

	// Default constructor
	public Person()
	{
		this.name = null;
		this.age = 0;
	}

	// Constructor with parameters
	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

	public string Name
	{
		get { return this.name; }
		set { this.name = value; }
	}

	public int Age
	{
		get { return this.age; }
		set { this.age = value; }
	}
}