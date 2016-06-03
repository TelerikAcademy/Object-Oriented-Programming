public class Tomcat : Cat
{
	public override int Speed
	{
		get
		{
			return 20;
		}
	}

	public override string GetName()
	{
		return "tomcat";
	}

	public override void SayMyaau()
	{
		System.Console.WriteLine("Tomcat muaaaaaaaau");
	}
}
