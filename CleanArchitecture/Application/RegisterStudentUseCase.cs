using CleanArchitecture.Application;
using CleanArchitecture.Core;

namespace CleanArchitecture.Application;

public class RegisterStudentUseCase
{
    private readonly IStudentRepository _repository;

    public RegisterStudentUseCase(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Student> Execute(string name, int age)
    {
        var student = new Student(name, age);
        await _repository.AddAsync(student);
        return student;
    }
}
