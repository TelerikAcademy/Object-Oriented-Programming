namespace LINQ_Extenstion_Methods
{
    using System.Collections.Generic;

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return this.Id + "; Name: " + this.Name + "; Courses: " + this.Courses.Count;
        }
    }
}
