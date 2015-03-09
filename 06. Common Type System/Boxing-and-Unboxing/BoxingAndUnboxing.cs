using System;

namespace BoxingAndUnboxing
{
    interface IMovable
    {
        void Move(int x, int y);
    }

    // Very bad practice! Structures should
    // contain no logic, but only data!
    struct Point : IMovable
    {
        public int x, y;

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", x, y);
        }
    }

    class TestBoxingUnboxing
    {
        static void Main()
        {
			Point p1 = new Point();
			Console.WriteLine("p1={0}", p1); // p1=(0,0)

			IMovable p1mov = (IMovable)p1; // p1 si boxed
			IMovable p2mov = (IMovable)p1mov;
			// p1mov is not boxed second time,
			// because it is already boxed

			Point p2 = (Point)p2mov; // p2mov is unboxed
			p1.Move(-100, -100);
			p2.Move(100, 100);
			Console.WriteLine("p1 is moved to {0}", p1); // p1=(-100,-100)
			Console.WriteLine("p2 is moved to {0}", p2); // p2=(100,100)

			p1mov.Move(5, 5);
			Console.WriteLine("p1mov is moved to {0} ", p1mov); // p1mov=(5,5)
			Console.WriteLine("p2mov is also moved to {0}", p2mov); // p2mov=(5,5)            

        }
    }
}
