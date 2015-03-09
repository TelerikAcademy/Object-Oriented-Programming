using System;

class OverloadingSystemObject
{
    static void Main()
    {
        Student firstStudent = new Student();
        firstStudent.Name = "Bai Ivan";
        firstStudent.Age = 68;
        Console.WriteLine(firstStudent); // called firstStudent.ToString()

        Student secondStudent = new Student();
        if (firstStudent != secondStudent)  // it is true
            Console.WriteLine("{0} != {1}", firstStudent, secondStudent);

        secondStudent.Name = "Bai Ivan";
        secondStudent.Age = 68;
        if (firstStudent == secondStudent)  // it is true
            Console.WriteLine("{0} == {1}", firstStudent, secondStudent);

        secondStudent.Age = 70;
        if (firstStudent != secondStudent)  // it is true
            Console.WriteLine("{0} != {1}", firstStudent, secondStudent);
    }
}
