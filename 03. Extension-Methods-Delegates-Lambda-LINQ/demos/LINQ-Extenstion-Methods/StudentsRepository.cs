using System.Collections.Generic;

public class StudentsRepository
{
    public IEnumerable<Student> GetAllStudents()
    {
        var oop = new Course { Id = 1, Name = "OOP" };
        var csharp = new Course { Id = 2, Name = "CSharp" };
        var javaScript = new Course { Id = 3, Name = "JavaScript" };
        var students = new List<Student>
        {
            new Student
                {
                    Id = 1,
                    Name = "Ivan",
                    Courses = new List<Course> { oop, javaScript }
                },
            new Student
                {
                    Id = 2,
                    Name = "Gosho",
                    Courses =
                        new List<Course> { oop, javaScript, csharp }
                },
            new Student
                {
                    Id = 3,
                    Name = "Pesho",
                    Courses = new List<Course> { csharp, javaScript }
                },
        };

        return students;
    }
}
