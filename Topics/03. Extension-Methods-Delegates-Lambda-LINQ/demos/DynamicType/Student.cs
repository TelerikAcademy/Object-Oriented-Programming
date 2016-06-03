public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string SayName()
    {
        return "I am " + this.Name;
    }
}
