using CleanArchitecture.Core;

namespace CleanArchitecture.Application;

public interface IStudentRepository
{
    Task AddAsync(Student student);
}
