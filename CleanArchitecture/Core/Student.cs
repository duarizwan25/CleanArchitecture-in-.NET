namespace CleanArchitecture.Core;

public class Student
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Student(string name, int age)
    {
        if (age < 16) throw new Exception("Student must be 16 or older");
        Name = name;
        Age = age;
    }
}
