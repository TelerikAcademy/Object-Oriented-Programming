public class StructuresExample
{
	static void Main()
	{
		Square square = new Square(
			new Point() { X = 5, Y = -3 },
			7,
			new Color() { RedValue = 73, GreenValue = 158, BlueValue = 76 },
			new Color() { RedValue = 0, GreenValue = 255, BlueValue = 133 },
			Edges.Rounded
		);
		System.Console.WriteLine(square);

		square.Edges = Edges.Straight;
		square.BorderColor = new Color() { 
			RedValue=0, GreenValue=0, BlueValue=0 };
		
		// Note: this will not compile (Point is value-type)
		//square.Location.X = square.Location.X + 10;

		Point location = square.Location;
		location.X += 10;
		square.Location = location;

		System.Console.WriteLine(square);
	}
}
