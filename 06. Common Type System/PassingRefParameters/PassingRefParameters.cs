using System;

namespace PassingRefParameters
{
    public struct Point 
    { 
        internal int x;
        internal int y; 
    }

    public class MultiplyPoint
    {
        public static void IncorrectMultiplyBy2(Point point)
        {
            point.x *= 2;
            point.y *= 2;
        }

        public static void MultiplyBy2(ref Point point)
        {
            point.x *= 2;
            point.y *= 2;
        }
    }

    public class Student
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
        }

        static void IncorrectModifyStudent(Student student)
        {
            student = new Student("Changed: " + student.name);
        }

        static void ModifyStudent(ref Student student)
        {
            student = new Student("Changed: " + student.name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test passing class (reference type) by reference:");
            Student s = new Student("Nakov");
            Console.WriteLine(s.name);
            IncorrectModifyStudent(s);
            Console.WriteLine(s.name);
            ModifyStudent(ref s);
            Console.WriteLine(s.name);
            Console.WriteLine();

            Console.WriteLine("Test passing struct (value type) by reference:");
            Point p = new Point() { x = 5, y = -8 };
            Console.WriteLine("p=({0},{1})", p.x, p.y); 
            MultiplyPoint.IncorrectMultiplyBy2(p);
            Console.WriteLine("p=({0},{1})", p.x, p.y); 
            MultiplyPoint.MultiplyBy2(ref p);
            Console.WriteLine("p=({0},{1})", p.x, p.y);        
        }
    }
}
