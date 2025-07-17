using CleanArchitecture.Application;
using CleanArchitecture.Core;


namespace CleanArchitecture.Infrastructure;

public class StudentRepository : IStudentRepository
{
    private static readonly List<Student> _students = new();

    public Task AddAsync(Student student)
    {
        _students.Add(student);
        return Task.CompletedTask;
    }
}
