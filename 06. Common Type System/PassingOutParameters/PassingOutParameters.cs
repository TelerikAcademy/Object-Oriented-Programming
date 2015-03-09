using System;

namespace PassingOutParameters
{
    public struct Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public struct Dimensions
    {
        public int width, height;
        public Dimensions(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }

    public class Rectangle
    {
        private int x, y, width, height;
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void GetLocationAndDimensions(
			out Point location, out Dimensions dimensions)
        {
            location = new Point(x, y);
            dimensions = new Dimensions(width, height);
        }

        static void Main()
        {
            Rectangle rect = new Rectangle(5, 10, 12, 8);

            Point location = new Point(0,0);
			Dimensions dimensions = new Dimensions(1, 2); 

            // Location and dimension are not pre-initialized!
            rect.GetLocationAndDimensions(out location, out dimensions);

            Console.WriteLine("({0}, {1}, {2}, {3})",
                location.x, location.y,
                dimensions.width, dimensions.height);
        }
    }
}