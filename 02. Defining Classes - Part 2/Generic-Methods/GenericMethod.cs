using System;

class GenericMethod
{
    public static T Min<T>(T first, T second) 
        where T : IComparable<T>
    {
        if (first.CompareTo(second) <= 0)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    static void Main()
    {
        int i = 5;
        int j = 7;
        int min = Min<int>(i, j);
        Console.WriteLine("Min({0}, {1}) = {2}", i, j, min);

        string firstString = "Rakiya";
        string secondString = "Beer";
        string minString = Min<string>(firstString, secondString);
        Console.WriteLine("Min({0}, {1}) = {2}", firstString, secondString, minString);

        //Point p1 = new Point();
        //Point p2 = new Point();
        //Point minPoint = Min(p1, p2); // This will not compile
    }
}
