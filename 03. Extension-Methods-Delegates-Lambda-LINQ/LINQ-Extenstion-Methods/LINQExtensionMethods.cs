namespace LINQ_Extenstion_Methods
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class LINQExtensionMethods
    {
        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            Course oop = new Course { Id = 1, Name = "OOP" };
            Course cSharp = new Course { Id = 2, Name = "CSharp" };
            Course javaScript = new Course { Id = 3, Name = "JavaScript" };

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ivan", Courses = new List<Course> { oop, javaScript }},
                new Student { Id = 2, Name = "Gosho", Courses = new List<Course> { oop, javaScript, cSharp }},
                new Student { Id = 3, Name = "Pesho", Courses = new List<Course> { cSharp, javaScript }},
            };

            // where
            var someStudents = students.Where(st => st.Name == "Ivan" || st.Name == "Pesho");
            PrintCollection(someStudents);

            // first
            Student first = students.FirstOrDefault(st => st.Courses.Count == 4); // First
            Console.WriteLine(first);

            // select
            var projectedItems = students.Select(st => new Student { Name = st.Id.ToString(), Courses = new List<Course>() });
            PrintCollection(projectedItems);

            // select to annonymous
            var annStudents = students.Select(st => new { Id = st.Id, Courses = st.Courses.Count });
            PrintCollection(annStudents);

            // order by
            var ordered = students.OrderBy(st => st.Courses.Count).ThenBy(st => st.Name);
            PrintCollection(ordered);

            // any
            bool checkAny = students.Any(st => st.Name.StartsWith("I"));
            Console.WriteLine(checkAny);

            // all
            bool checkAll = students.All(st => st.Name != string.Empty);
            Console.WriteLine(checkAll);
            checkAll = students.All(st => st.Id > 2);
            Console.WriteLine(checkAll);

            // ToList and ToArray
            Student[] arrayOfStudents = students.ToArray();
            PrintCollection(arrayOfStudents);
            List<Student> listOfStudents = arrayOfStudents.ToList();
            PrintCollection(listOfStudents);

            // reading string of numbers separated by space
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            PrintCollection(numbers);

            // reverse
            students.Reverse();
            PrintCollection(students);

            // average
            double averageCourses = students.Average(st => st.Courses.Count);
            Console.WriteLine(averageCourses);

            // max
            int max = students.Max(st => st.Courses.Count);
            Console.WriteLine(max);

            // min
            int min = students.Min(st => st.Courses.Count);
            Console.WriteLine(min);
            
            // count
            int count = students.Count(st => st.Name.Length > 4);
            Console.WriteLine(count);

            // sum
            int sum = students.Sum(st => st.Courses.Count);
            Console.WriteLine(sum);

            // extension methods
            var someCollection = students
                .Where(st => st.Id > 1)
                .OrderBy(st => st.Name)
                .ThenBy(st => st.Courses.Count)
                .Select(st => new
                {
                    Name = st.Name,
                    Courses = st.Courses.Count
                })
                .ToArray();

            PrintCollection(someCollection);

            // nesting

            var someOtherStudents = students.Where(st => st.Courses.Any(c => c.Name == "OOP")).OrderBy(st => st.Name);
            PrintCollection(someOtherStudents);
        }
    }
}
