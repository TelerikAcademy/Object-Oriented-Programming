public class Kitten : Cat
{
	public override int Speed
	{
		get
		{
			return 5;
		}
	}

	public override string GetName()
	{
		return "kitten";
	}

	public override void SayMyaau()
	{
		System.Console.WriteLine("Kitten miau, miaau");
	}
}
