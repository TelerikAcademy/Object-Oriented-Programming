using System;

public class Student
{
	public string Name { get; set; }
	public int Age { get; set; }

    public override bool Equals(object param)
    {
        // If the cast is invalid, the result will be null
        Student student = param as Student;

        // Check if we have valid not null Student object
		if (student == null)
		{
			return false;
		}

        // Compare the reference type member fields
		if (!Object.Equals(this.Name, student.Name))
		{
			return false;
		}

        // Compare the value type member fields
		if (this.Age != student.Age)
		{
			return false;
		}
        return true;
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1, student2));
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Age.GetHashCode();
    }

    public override string ToString()
    {
        return String.Format(
            "Student(Name: {0}, Age: {1})", 
			this.Name ?? "<unnamed>", this.Age);
    }
}